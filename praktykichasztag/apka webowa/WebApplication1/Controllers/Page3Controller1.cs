using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

public class Page3Controller : Controller
{
    public IActionResult Index()
    {
        var model = new Page3Model
        {
            Brand = "Apple",
            Model = "iPhone 14",
            BatteryLife = 20
        };
        return View(model);
    }
}
