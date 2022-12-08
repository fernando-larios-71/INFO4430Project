using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _4430Project.Models;

namespace _4430Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //Home Page View
    public IActionResult Index()
    {
        return View();
    }
    //Pokemon Page View
    public IActionResult Pokemon()
    {
#pragma warning disable CS8974 // Converting method group to non-delegate type
        return View(Pokemon);
#pragma warning restore CS8974 // Converting method group to non-delegate type
    }
    //DND Page View
    public IActionResult DND()
    {
#pragma warning disable CS8974 // Converting method group to non-delegate type
        return View(DND);
#pragma warning restore CS8974 // Converting method group to non-delegate type
    }
    //MTG Page View
    public IActionResult MTG()
    {
#pragma warning disable CS8974 // Converting method group to non-delegate type
        return View(MTG);
#pragma warning restore CS8974 // Converting method group to non-delegate type
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
