using System.Text.Json.Serialization;

namespace PAW.Mvc.Models
{
    public class CatalogViewModel
    {
        [JsonPropertyName("identifier")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
