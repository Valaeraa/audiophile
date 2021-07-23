using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audiophile.Domain.Entities
{
    public class Include : BaseEntity
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("item")]
        public string Item { get; set; }
    }
}
