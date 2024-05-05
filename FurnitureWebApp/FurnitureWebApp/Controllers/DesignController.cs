using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebApp.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
