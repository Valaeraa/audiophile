using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audiophile.Domain.Entities
{
    public class Image : BaseEntity
    {
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        [JsonPropertyName("tablet")]
        public string Tablet { get; set; }

        [JsonPropertyName("desktop")]
        public string Desktop { get; set; }
    }
}
