using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
