using InanceWebApp.DAL;
using Microsoft.EntityFrameworkCore;

namespace InanceWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt=>
            {
                opt.UseSqlServer("server=.;database=bb207_Inance;Trusted_connection=true;Integrated security=true;Encrypt=false");
            });
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}