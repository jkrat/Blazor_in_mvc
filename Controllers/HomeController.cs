using Blazor_in_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blazor_in_mvc.Controllers;

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

    [Route("[action]/{startValue:int?}")]
    [HttpGet]
    public IActionResult Counter(int? startValue)
    {
        var value = startValue ?? 0;
        var model = new CounterModel { StartValue = value };

        return View(model);
    }

    public IActionResult CallService()
    {
        return View();
    }

    public IActionResult CallController()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

public class HomeViewModel
{
    public int StartValue { get; set; } = 5;
}
