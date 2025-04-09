using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UnitConverter.Models;

namespace UnitConverter.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Length()
    {
        return View();
    }

    public IActionResult Weight()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Temperature()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Convert(float value, string iunit, string funit, string button = "Index")
    {
        if (funit == null || iunit == null)
        {
            TempData["result"] = "Input units";
            return RedirectToAction(button.ToString());
        }
        float result = UnitConversion.ConvertLength(value, iunit, funit);
        TempData["result"] = result.ToString() + " " + funit;
        return RedirectToAction(button.ToString());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
