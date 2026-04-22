// ============================================================================
// Program.cs — Application entry point & service configuration
// ============================================================================
// This file configures:
//   1. LOGGING  — Console logging with timestamps via ILogger
//   2. CACHING  — In-Memory caching via IMemoryCache (AddMemoryCache)
//   3. SWAGGER  — Swagger / OpenAPI documentation for API endpoints
//   4. MVC      — Standard MVC controller routing + API controllers
// ============================================================================

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------------------------
// LOGGING CONFIGURATION
// ---------------------------------------------------------------------------
// ASP.NET Core provides built-in logging via the ILogger<T> interface.
// By default, it includes Console, Debug, and EventSource providers.
// Here we explicitly configure console logging with a custom timestamp format
// so that every log line printed to the console shows a precise timestamp.
// This makes it easy to compare response times for cached vs non-cached calls.
// ---------------------------------------------------------------------------
builder.Logging.ClearProviders();           // Remove default providers
builder.Logging.AddConsole();               // Re-add Console with custom format
builder.Logging.AddDebug();                 // Also log to Debug output (Visual Studio)
builder.Logging.SetMinimumLevel(LogLevel.Information); // Show Info and above

// ---------------------------------------------------------------------------
// IN-MEMORY CACHING CONFIGURATION
// ---------------------------------------------------------------------------
// AddMemoryCache() registers the IMemoryCache service in the DI container.
// IMemoryCache stores data in the web server's memory, making subsequent
// reads extremely fast (no network or disk I/O). It is ideal for:
//   - Data that is expensive to compute or fetch
//   - Data that does not change frequently
//   - Single-server deployments (cache is NOT shared across servers)
// ---------------------------------------------------------------------------
builder.Services.AddMemoryCache();

// ---------------------------------------------------------------------------
// MVC + API CONTROLLERS
// ---------------------------------------------------------------------------
builder.Services.AddControllersWithViews();

// ---------------------------------------------------------------------------
// SWAGGER / OPENAPI CONFIGURATION
// ---------------------------------------------------------------------------
// Swagger provides interactive API documentation. It auto-discovers all
// [ApiController] endpoints and presents them in a browser-based UI at
// /swagger. This is invaluable for testing caching & logging behaviour.
// ---------------------------------------------------------------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "CachingLoggingDemo API",
        Version = "v1",
        Description = "ASP.NET Core MVC application demonstrating In-Memory Caching and Logging with ILogger."
    });
});

var app = builder.Build();

// ---------------------------------------------------------------------------
// MIDDLEWARE PIPELINE
// ---------------------------------------------------------------------------

// Enable Swagger UI in all environments for demonstration purposes
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "CachingLoggingDemo API v1");
    // Do NOT set RoutePrefix to "" so it doesn't conflict with MVC Home route
});

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default MVC route — serves Views (Home/Index, etc.)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Log a startup message to demonstrate logging is working from the start
var logger = app.Services.GetRequiredService<ILogger<Program>>();
logger.LogInformation("=== CachingLoggingDemo application started at {Time} ===", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
logger.LogInformation("Swagger UI available at /swagger");
logger.LogInformation("MVC Home page available at /");

app.Run();
