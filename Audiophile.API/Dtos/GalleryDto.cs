using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audiophile.API.Dtos
{
    public class GalleryDto
    {
        public ImageDto First { get; set; }
        public ImageDto Second { get; set; }
        public ImageDto Third { get; set; }
    }
}
