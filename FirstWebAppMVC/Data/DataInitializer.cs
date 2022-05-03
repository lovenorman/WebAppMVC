using Microsoft.EntityFrameworkCore;

namespace FirstWebAppMVC.Data
{
    public class DataInitializer
    {
        private ApplicationDbContext _context;

        public DataInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            _context.Database.Migrate();
            //SeedProduct();
        }

        //private void SeedProduct()
        //{
        //    _context.Products.Add(new Product { Name = "Penna" });
        //    _context.Products.Add(new Product { Name = "Sudd" });
        //    _context.Products.Add(new Product { Name = "Dator" });

        //    _context.SaveChanges();
        //}
    }
}

        