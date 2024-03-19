using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Walk_in_Style.Models;

namespace Walk_in_Style.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult services()
    {
        return View();
    }
    public IActionResult contact()
    {
        return View();
    }
    public IActionResult about()
    {
        return View();
    }
    public IActionResult login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
