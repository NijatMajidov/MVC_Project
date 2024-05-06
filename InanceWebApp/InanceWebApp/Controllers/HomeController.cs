using InanceWebApp.DAL;
using InanceWebApp.Models;
using InanceWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InanceWebApp.Controllers
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
            
            //Client client = new Client()
            //{ 
            //    Name = "Test",
            //    Comment = "chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum",
            //    UserPhoto = "client-1.jpg"
            //};
            //Client client2 = new Client()
            //{
            //    Name = "User1234",
            //    Comment = "chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum",
            //    UserPhoto = "client-2.jpg"
            //};
            //List<Client> clients = new List<Client>();
            //clients.Add(client);
            //clients.Add(client2);

            //Service service = new Service()
            //{
            //    Name = "Maintenance",
            //    Description = "*****when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal",
            //    Img = "s1.png"
            //};
            //Service service2 = new Service()
            //{
            //    Name = "Electrical",
            //    Description = "*****when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal",
            //    Img = "s2.png"
            //};
            //Service service3 = new Service()
            //{
            //    Name = "Plumbing",
            //    Description = "*****when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal",
            //    Img = "s3.png"
            //};
            //List<Service> services = new List<Service>();
            //services.Add(service);
            //services.Add(service2);
            //services.Add(service3);

            HomeVM homeVM = new HomeVM()
            { 
               Clients = _dbContext.clients.ToList(),
               Services = _dbContext.services.ToList(),
            };
            //_dbContext.clients.Add(client);
            //_dbContext.clients.Add(client2);
            //_dbContext.services.Add(service);
            //_dbContext.services.Add(service2);
            //_dbContext.services.Add(service3);
            //_dbContext.SaveChanges();
            
            return View(homeVM);
        }
    }
}
