using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Audiophile.Domain.Entities
{
    public class Product : BaseEntity
    {
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }
        public int ImageId { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("new")]
        public bool New { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("features")]
        public string Features { get; set; }

        [JsonPropertyName("includes")]
        public List<Include> Includes { get; set; }

        [JsonPropertyName("gallery")]
        public Gallery Gallery { get; set; }
        public int GalleryId { get; set; }

        [JsonPropertyName("others")]
        public List<Other> Others { get; set; }
    }
}
