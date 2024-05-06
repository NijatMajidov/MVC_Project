using InanceWebApp.DAL;
using InanceWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InanceWebApp.Controllers
{
    public class ServiceController : Controller
    {
        AppDbContext _dbContext;
        public ServiceController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var service = _dbContext.services.ToList();
            return View(service);
        }
    }
}
