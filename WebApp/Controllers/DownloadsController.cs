using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class DownloadsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Downloads";
            return View();
        }
    }
}
