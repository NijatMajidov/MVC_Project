using FurnitureWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebApp.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture = new Furniture()
            {
                Id = 1,
                Name = "Divan",
                Price = 800,
                Img = "images/img-4.png"

            };
            Furniture furniture1 = new Furniture()
            {
                Id = 2,
                Name = "Divan",
                Price = 800,
                Img = "images/img-1.png"

            };  
            Furniture furniture2 = new Furniture()
            {
                Id = 3,
                Name = "Stul",
                Price = 800,
                Img = "images/img-2.png"};
    
            Furniture furniture3 = new Furniture()
            {
                Id = 4,
                Name = "Stul",
                Price = 800,
                Img = "images/img-3.png"

            }; 

            Furniture furniture4 = new Furniture()
             {
                 Id = 1,
                 Name = "Masa",
                 Price = 800,
                 Img = "images/img-5.png"

            };

            List<Furniture> furnitures= new List<Furniture>();
            furnitures.Add(furniture);
            furnitures.Add(furniture1);
            furnitures.Add(furniture2);
            furnitures.Add(furniture3);
            furnitures.Add(furniture4);

            ViewBag.Furnitures = furnitures;
            return View();
        }
    }
}
