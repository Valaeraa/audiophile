using System.Collections.Generic;

namespace Audiophile.API.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public ImageDto Image { get; set; }
        public string Category { get; set; }
        public bool New { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Features { get; set; }
        public List<IncludeDto> Includes { get; set; }
        public GalleryDto Gallery { get; set; }
        public List<OtherDto> Others { get; set; }
    }
}
