using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audiophile.API.Dtos
{
    public class IncludeDto
    {
        public int Quantity { get; set; }
        public string Item { get; set; }
    }
}
