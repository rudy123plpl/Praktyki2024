using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

public class Page1Controller : Controller
{
    public IActionResult Index()
    {
        var model = new Page1Model
        {
            Brand = "Samsung",
            HasGPS = false,
            BatteryLife = 48,
             ImageUrl = "/images/smartwatch.jpg"
        };
        return View(model);
    }
}
