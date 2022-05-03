using System.ComponentModel.DataAnnotations;

namespace FirstWebAppMVC.Data
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        
    }
}
