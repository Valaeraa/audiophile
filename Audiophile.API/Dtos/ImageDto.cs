using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audiophile.API.Dtos
{
    public class ImageDto
    {
        public string Mobile { get; set; }
        public string Tablet { get; set; }
        public string Desktop { get; set; }
    }
}
