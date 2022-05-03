using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace FirstWebAppMVC.Services
{
    public interface IAnimalService
    {
        List<Animal> GetLatest();
    }

    public class AnimalService : IAnimalService
    {
        private readonly IOptions<AnimalSettings> _settings;

        public AnimalService(IOptions<AnimalSettings> settings)
        {
            _settings = settings;
        }

        public List<Animal> GetLatest()
        {
            var httpClient = new HttpClient();
            var data = httpClient.GetStringAsync(
                _settings.Value.Url).Result;

            return JsonConvert.DeserializeObject<List<Animal>>(data);
        }
    }

    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Latin_Name { get; set; }
        public string Habitat { get; set; }
    }

    public class AnimalSettings
    {
        public string Url { get; set; }
        public int Maxantal { get; set; }
    }
}
