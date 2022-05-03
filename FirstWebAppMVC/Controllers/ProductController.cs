using FirstWebAppMVC.Data;
using FirstWebAppMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        /*
            - här skriver vi kod som "KONTROLLERAR FLÖDET" vad som ska hända
            - hämta från databas osv
            - validera
            - lägg properties i "Model"
        */

        public IActionResult Index()
        {
            var model = new ProductIndexViewModel
            {
                Items = _context.Products.Select(i => new ProductIndexViewModel.ProductViewModel
                {
                    Id = i.Id,
                    Name = i.Name,
                }).ToList()
            };
            

            return View(model);
        }
    }
}
