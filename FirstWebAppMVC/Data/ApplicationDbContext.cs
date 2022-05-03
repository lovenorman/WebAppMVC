using FirstWebAppMVC.Services;
using Microsoft.EntityFrameworkCore;

namespace FirstWebAppMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Animal> Animals { get; set; }

    }

}
