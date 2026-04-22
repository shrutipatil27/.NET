namespace CachingLoggingDemo.Models;

/// <summary>
/// Represents a product entity used to demonstrate caching and logging.
/// This model simulates data that would typically come from a database.
/// </summary>
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
