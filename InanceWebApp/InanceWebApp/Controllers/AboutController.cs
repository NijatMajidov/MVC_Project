using Microsoft.AspNetCore.Mvc;

namespace InanceWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
