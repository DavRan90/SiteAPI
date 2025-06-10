using Microsoft.EntityFrameworkCore;

namespace SiteAPI.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Element> Elements { get; set; }
        public DbSet<Models.Site> Sites { get; set; }

        //public DbSet<Models.Menu> Menus { get; set; }
    }
}
