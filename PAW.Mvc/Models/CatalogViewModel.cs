using Microsoft.AspNetCore.Mvc.ModelBinding;
using PAW.Mvc.Helper.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PAW.Mvc.Models
{
    public class CatalogViewModel
    {
        [ValidateId]
        [JsonPropertyName("identifier")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [BindNever]
        public string Hash {  get; set; }
    }
}
