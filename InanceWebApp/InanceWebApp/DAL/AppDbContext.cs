using InanceWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InanceWebApp.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Client> clients { get; set; }
        public DbSet<Service> services { get; set; }

    }
}
