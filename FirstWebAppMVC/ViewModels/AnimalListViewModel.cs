namespace FirstWebAppMVC.ViewModels
{
    public class AnimalListViewModel
    {
        public List<AnimalListItemViewModel> Animals { get; set; }

        public class AnimalListItemViewModel
        {
            public string Name { get; set; }
            public string Latin_Name { get; set; }
            public string Habitat { get; set; }
        }
    }

   
}
