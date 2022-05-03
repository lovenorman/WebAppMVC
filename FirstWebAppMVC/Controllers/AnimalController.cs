using FirstWebAppMVC.Services;
using FirstWebAppMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAppMVC.Controllers
{
    public class AnimalController : Controller
    {
        private IAnimalService _animalService;

        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }
        public IActionResult Index()
        {
            var model = new AnimalListViewModel();
            model.Animals = _animalService.GetLatest().Select(a => new
                AnimalListViewModel.AnimalListItemViewModel
            {
                Name = a.Name,
                Latin_Name = a.Latin_Name,
                Habitat = a.Habitat,
            }
                ).ToList();

            return View(model);
        }

        //public IActionResult Index()
        //{
        //    var model = new KrisInfoListViewModel();
        //    model.Items = _krisInfoService.GetLatest().Select(e => new
        //        KrisInfoListViewModel.KrisInfoListItemViewModel
        //    {
        //        Headline = e.Headline,
        //        Identitifer = e.Identitifer
        //    }
        //        ).ToList();




        //    return View(model);
        //}
    }
}
