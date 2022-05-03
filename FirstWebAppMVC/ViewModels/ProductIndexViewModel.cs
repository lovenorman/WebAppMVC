namespace FirstWebAppMVC.ViewModels
{
    public class ProductIndexViewModel
    {
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public List<ProductViewModel> Items { get; set; }
    }

    
}
