using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using CachingLoggingDemo.Models;

namespace CachingLoggingDemo.Controllers;

// ============================================================================
// ProductController — Demonstrates ILogger Logging & IMemoryCache Caching
// ============================================================================
// This controller is registered as BOTH an MVC controller (returns Views)
// AND an API controller (returns JSON via /api/products/*).
//
// KEY CONCEPTS DEMONSTRATED:
// 1. ILogger<T>      — Structured logging at Information, Warning, Error levels
// 2. IMemoryCache     — In-memory caching with absolute expiration
// 3. Stopwatch        — Timing requests to show cached vs non-cached performance
// ============================================================================
public class ProductController : Controller
{
    // -----------------------------------------------------------------------
    // DEPENDENCY INJECTION
    // -----------------------------------------------------------------------
    // ILogger<ProductController> — Logging scoped to this controller.
    //   ASP.NET Core automatically injects this via the DI container.
    //   Log messages include the category name "ProductController" for filtering.
    //
    // IMemoryCache — The in-memory cache registered in Program.cs via AddMemoryCache().
    //   Stores key-value pairs in server memory for fast retrieval.
    // -----------------------------------------------------------------------
    private readonly ILogger<ProductController> _logger;
    private readonly IMemoryCache _cache;

    // Cache key constant — avoids typos and makes the key easy to change
    private const string ProductsCacheKey = "ProductsList";

    public ProductController(ILogger<ProductController> logger, IMemoryCache cache)
    {
        _logger = logger;
        _cache = cache;

        // Log when the controller is instantiated (once per request in default scope)
        _logger.LogInformation("[{Timestamp}] ProductController instantiated",
            DateTime.Now.ToString("HH:mm:ss.fff"));
    }

    // =======================================================================
    // SIMULATED DATA SOURCE
    // =======================================================================
    // In a real application this would be a database call (EF Core, Dapper, etc.).
    // We simulate a slow data source with Task.Delay to make the caching benefit
    // clearly visible in the response times.
    // =======================================================================
    private static async Task<List<Product>> FetchProductsFromDataSourceAsync()
    {
        // Simulate a 2-second database/API delay
        await Task.Delay(2000);

        return new List<Product>
        {
            new() { Id = 1, Name = "Wireless Keyboard",      Category = "Electronics", Price = 49.99m,  Stock = 150 },
            new() { Id = 2, Name = "Bluetooth Mouse",         Category = "Electronics", Price = 29.99m,  Stock = 300 },
            new() { Id = 3, Name = "USB-C Hub (7-port)",      Category = "Accessories", Price = 39.99m,  Stock = 200 },
            new() { Id = 4, Name = "Mechanical Keyboard",     Category = "Electronics", Price = 129.99m, Stock = 75  },
            new() { Id = 5, Name = "4K Monitor 27\"",         Category = "Displays",    Price = 349.99m, Stock = 50  },
            new() { Id = 6, Name = "Laptop Stand (Aluminum)", Category = "Accessories", Price = 59.99m,  Stock = 120 },
            new() { Id = 7, Name = "Webcam 1080p",            Category = "Electronics", Price = 79.99m,  Stock = 90  },
            new() { Id = 8, Name = "Noise-Cancelling Headphones", Category = "Audio",   Price = 199.99m, Stock = 60  },
        };
    }

    // =======================================================================
    // MVC ACTION — GET /Product  (returns a Razor View)
    // =======================================================================
    public async Task<IActionResult> Index()
    {
        _logger.LogInformation("[{Timestamp}] MVC Product/Index action invoked",
            DateTime.Now.ToString("HH:mm:ss.fff"));

        var response = await GetProductsWithCachingAsync();
        return View(response);
    }

    // =======================================================================
    // API ENDPOINT — GET /api/products  (returns JSON for Swagger)
    // =======================================================================
    // This endpoint is accessible from Swagger UI and returns JSON data.
    // It demonstrates the same caching and logging logic as the MVC action.
    // =======================================================================
    [HttpGet("/api/products")]
    public async Task<IActionResult> GetProductsApi()
    {
        _logger.LogInformation("[{Timestamp}] API /api/products endpoint invoked",
            DateTime.Now.ToString("HH:mm:ss.fff"));

        var response = await GetProductsWithCachingAsync();
        return Ok(response);
    }

    // =======================================================================
    // API ENDPOINT — GET /api/products/{id}  (returns a single product)
    // =======================================================================
    [HttpGet("/api/products/{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        _logger.LogInformation("[{Timestamp}] API /api/products/{Id} endpoint invoked",
            DateTime.Now.ToString("HH:mm:ss.fff"), id);

        var response = await GetProductsWithCachingAsync();
        var product = response.Products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            // LOG A WARNING — product not found is a client error, not a server error
            _logger.LogWarning("[{Timestamp}] Product with Id={Id} was NOT found",
                DateTime.Now.ToString("HH:mm:ss.fff"), id);
            return NotFound(new { message = $"Product with Id={id} not found." });
        }

        _logger.LogInformation("[{Timestamp}] Returning product: {ProductName} (Id={Id})",
            DateTime.Now.ToString("HH:mm:ss.fff"), product.Name, id);
        return Ok(product);
    }

    // =======================================================================
    // API ENDPOINT — POST /api/products/clear-cache  (clears the cache)
    // =======================================================================
    // Useful for testing: clear the cache and the next GET will be slow again.
    // =======================================================================
    [HttpPost("/api/products/clear-cache")]
    public IActionResult ClearCache()
    {
        _cache.Remove(ProductsCacheKey);
        _logger.LogWarning("[{Timestamp}] Cache cleared manually via API",
            DateTime.Now.ToString("HH:mm:ss.fff"));
        return Ok(new { message = "Cache cleared. Next request will fetch fresh data." });
    }

    // =======================================================================
    // CORE CACHING LOGIC
    // =======================================================================
    // This private method encapsulates the caching pattern used by both the
    // MVC action and the API endpoint:
    //
    // 1. Start a Stopwatch to measure total time.
    // 2. Try to get data from IMemoryCache using TryGetValue().
    // 3. If cache HIT  → return cached data immediately (fast, ~0ms).
    // 4. If cache MISS → fetch from data source (slow, ~2000ms), then store
    //    the result in the cache with a 60-second absolute expiration.
    // 5. Log the outcome at the appropriate level.
    // =======================================================================
    private async Task<CacheResponseViewModel> GetProductsWithCachingAsync()
    {
        var stopwatch = Stopwatch.StartNew();
        var response = new CacheResponseViewModel();

        // ---------------------------------------------------------------
        // CACHE LOOKUP — TryGetValue checks if the key exists in memory
        // ---------------------------------------------------------------
        if (_cache.TryGetValue(ProductsCacheKey, out List<Product>? cachedProducts) && cachedProducts != null)
        {
            // CACHE HIT — data is already in memory
            stopwatch.Stop();
            _logger.LogInformation(
                "[{Timestamp}] CACHE HIT — Returning {Count} products from cache in {Elapsed}ms",
                DateTime.Now.ToString("HH:mm:ss.fff"), cachedProducts.Count, stopwatch.ElapsedMilliseconds);

            response.Products = cachedProducts;
            response.IsFromCache = true;
            response.FetchedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            response.ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            response.Message = $"✅ Data served from CACHE in {stopwatch.ElapsedMilliseconds}ms";
        }
        else
        {
            // CACHE MISS — data must be fetched from the data source
            _logger.LogInformation("[{Timestamp}] CACHE MISS — Fetching products from data source...",
                DateTime.Now.ToString("HH:mm:ss.fff"));

            try
            {
                var products = await FetchProductsFromDataSourceAsync();
                stopwatch.Stop();

                // -----------------------------------------------------------
                // CACHE STORAGE — Set stores the data with expiration options
                // -----------------------------------------------------------
                // MemoryCacheEntryOptions configures how long the cached item lives:
                //   - AbsoluteExpirationRelativeToNow: Item expires 60 seconds after being added
                //   - SlidingExpiration: (optional) Item expires if not accessed within N seconds
                // -----------------------------------------------------------
                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(60))  // Expire after 60 seconds
                    .SetSlidingExpiration(TimeSpan.FromSeconds(30))   // Expire if idle for 30 seconds
                    .SetPriority(CacheItemPriority.Normal);           // Eviction priority under memory pressure

                _cache.Set(ProductsCacheKey, products, cacheOptions);

                _logger.LogInformation(
                    "[{Timestamp}] Data fetched and CACHED — {Count} products in {Elapsed}ms (cache TTL: 60s)",
                    DateTime.Now.ToString("HH:mm:ss.fff"), products.Count, stopwatch.ElapsedMilliseconds);

                response.Products = products;
                response.IsFromCache = false;
                response.FetchedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                response.ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                response.Message = $"🔄 Data fetched from SOURCE in {stopwatch.ElapsedMilliseconds}ms (now cached for 60s)";
            }
            catch (Exception ex)
            {
                // LOG AN ERROR — unexpected failures during data fetch
                stopwatch.Stop();
                _logger.LogError(ex, "[{Timestamp}] ERROR fetching products from data source",
                    DateTime.Now.ToString("HH:mm:ss.fff"));

                response.Message = "❌ Error fetching products. Check server logs for details.";
                response.ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            }
        }

        return response;
    }
}
