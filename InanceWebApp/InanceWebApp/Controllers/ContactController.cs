using Microsoft.AspNetCore.Mvc;

namespace InanceWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
