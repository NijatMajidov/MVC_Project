using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
