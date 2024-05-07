using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
