using System.Text.Json.Serialization;

namespace Audiophile.Domain.Entities
{
    public class Other : BaseEntity
    {
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("image")]
        public Image Image { get; set; }
    }
}