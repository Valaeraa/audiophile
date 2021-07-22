using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audiophile.Domain.Entities
{
    public class Gallery
    {
        public Image First { get; set; }
        public Image Second { get; set; }
        public Image Third { get; set; }
    }
}
