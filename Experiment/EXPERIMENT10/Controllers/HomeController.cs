using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CachingLoggingDemo.Models;

namespace CachingLoggingDemo.Controllers;

// ============================================================================
// HomeController — Demonstrates basic ILogger usage in MVC actions
// ============================================================================
// ILogger<HomeController> is injected via constructor injection.
// Each action method logs an Information-level message so you can see
// the request flow in the console output with timestamps.
// ============================================================================
public class HomeController : Controller
{
    // ILogger<T> — Provides structured logging scoped to this controller.
    // The category name "HomeController" appears in log output for filtering.
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Logs an info message each time the Home page is visited
    public IActionResult Index()
    {
        _logger.LogInformation("[{Timestamp}] Home/Index action invoked",
            DateTime.Now.ToString("HH:mm:ss.fff"));
        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogInformation("[{Timestamp}] Home/Privacy action invoked",
            DateTime.Now.ToString("HH:mm:ss.fff"));
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        _logger.LogError("[{Timestamp}] Error page displayed — RequestId: {RequestId}",
            DateTime.Now.ToString("HH:mm:ss.fff"),
            Activity.Current?.Id ?? HttpContext.TraceIdentifier);

        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
