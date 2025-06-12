using APW.Architecture;
using PAW.Architecture.Providers;
using PAW.Models;
using System.Text.Json;

namespace PAW.Services
{
    public interface ICatalogService
    {
        Task<Catalog> GetCatalogAsync(int id);
    }

    public class CatalogService(IRestProvider restProvider) : ICatalogService
    {
        public async Task<Catalog> GetCatalogAsync(int id)
        {
            var result = await restProvider.GetAsync("https://localhost:7180/Catalog/", "1");
            var json = JsonSerializer.Deserialize<Catalog>(result);
            var catalog = await JsonProvider.DeserializeAsync<Catalog>(result);
            return catalog;
        }
    }
}
