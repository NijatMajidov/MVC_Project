using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
