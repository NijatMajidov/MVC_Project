using Microsoft.AspNetCore.Mvc;
using PurpleBuzzWebApp.DAL;
using PurpleBuzzWebApp.Models;
using PurpleBuzzWebApp.ViewModels;

namespace PurpleBuzzWebApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _dbContext;
        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            Card card = new Card()
            {
                Name = "UI/UX design",
                Description = "loresm ui ux dsad",
                bgPhoto = "services-01.jpg"
            };
            Card card2 = new Card()
            {
                Name = "Social Media",
                Description = "loresm sosial media dsad",
                bgPhoto = "services-2.jpg"
            };
            Card card3 = new Card()
            {
                Name = "Marketing",
                Description = "loresm marketing dsad",
                bgPhoto = "services-03.jpg"
            };
            Card card4 = new Card()
            {
                Name = "Graphic",
                Description = "loresm graphic dsad",
                bgPhoto = "services-04.jpg"
            };
            Card card5 = new Card()
            {
                Name = "Digtal Marketing",
                Description = "loresm digtal marketing dsad",
                bgPhoto = "services-05.jpg"
            };

            
            
            HomeVM homeVM = new HomeVM()
            {
                Cards = _dbContext.card.ToList(),
            };

            //_dbContext.cards.Add(card);
            //_dbContext.cards.Add(card2);
            //_dbContext.cards.Add(card3);
            //_dbContext.cards.Add(card4);
            //_dbContext.cards.Add(card5);
            _dbContext.SaveChanges();
            return View(homeVM);
        }
    }
}
