using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
