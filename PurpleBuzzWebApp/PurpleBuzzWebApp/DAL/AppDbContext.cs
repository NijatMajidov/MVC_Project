using System.Collections.Generic;

namespace PurpleBuzzWebApp.DAL
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Client> clients { get; set; }
        public DbSet<Service> services { get; set; }
    }
}
