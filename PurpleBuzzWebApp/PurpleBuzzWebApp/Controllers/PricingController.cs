using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzWebApp.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
