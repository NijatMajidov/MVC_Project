using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
