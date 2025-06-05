using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sala_Escape_05.Models;

namespace Sala_Escape_05.Controllers;

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
}
