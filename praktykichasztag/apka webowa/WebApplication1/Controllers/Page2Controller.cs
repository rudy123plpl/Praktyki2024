using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

public class Page2Controller : Controller
{
    public IActionResult Index()
    {
        var model = new Page2Model
        {
            Brand = "Dell",
            Processor = "Intel i7",
            RAM = 16
        };
        return View(model);
    }
}
