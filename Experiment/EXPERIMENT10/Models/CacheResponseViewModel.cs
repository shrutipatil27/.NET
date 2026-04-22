namespace CachingLoggingDemo.Models;

/// <summary>
/// ViewModel that wraps product data along with metadata about the cache status.
/// Used by views and API responses to show whether data came from cache or was freshly fetched.
/// </summary>
public class CacheResponseViewModel
{
    public List<Product> Products { get; set; } = new();
    public bool IsFromCache { get; set; }
    public string FetchedAt { get; set; } = string.Empty;
    public long ElapsedMilliseconds { get; set; }
    public string Message { get; set; } = string.Empty;
}
