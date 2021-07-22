using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audiophile.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public string Category { get; set; }
        public bool New { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Features { get; set; }
        public List<Include> Includes { get; set; }
        public Gallery Gallery { get; set; }
        public List<Other> Others { get; set; }
    }
}
