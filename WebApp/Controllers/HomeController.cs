using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        ViewData["Title"] = "Task Management you gonna love";
        return View();
    }
}
