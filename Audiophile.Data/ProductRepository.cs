using Audiophile.Domain.Entities;
using Audiophile.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audiophile.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly AudiophileContext _context;

        public ProductRepository(AudiophileContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
        {
            var products = await _context.Products.Include(x => x.Category).ToListAsync();

            return products;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            
            return product;
        }

        public async Task<IReadOnlyList<ProductCategory>> GetProductCategories()
        {
            var categories = await _context.ProductCategories.ToListAsync();

            return categories;
        }
    }
}
