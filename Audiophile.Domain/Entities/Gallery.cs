using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audiophile.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        [JsonPropertyName("first")]
        public Image First { get; set; }

        [JsonPropertyName("second")]
        public Image Second { get; set; }

        [JsonPropertyName("third")]
        public Image Third { get; set; }
    }
}
