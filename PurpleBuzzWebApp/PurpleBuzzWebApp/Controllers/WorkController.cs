using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzWebApp.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
