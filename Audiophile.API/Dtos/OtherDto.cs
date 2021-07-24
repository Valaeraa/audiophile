using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audiophile.API.Dtos
{
    public class OtherDto
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public ImageDto Image { get; set; }
    }
}
