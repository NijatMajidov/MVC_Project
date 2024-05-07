using Microsoft.EntityFrameworkCore;
using PurpleBuzzWebApp.Models;
using System.Collections.Generic;

namespace PurpleBuzzWebApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Card> card{ get; set; }
        //public DbSet<> services { get; set; }
    }
}
