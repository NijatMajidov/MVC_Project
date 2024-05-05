using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
