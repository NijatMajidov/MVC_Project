using Microsoft.EntityFrameworkCore;
using PurpleBuzzWebApp.DAL;

namespace PurpleBuzzWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer("server=.;database=bb207_Buzz;Trusted_connection=true;Integrated security=true;Encrypt=false");
            });
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}
