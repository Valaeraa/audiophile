using Audiophile.Domain.Entities;
using Audiophile.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IReadOnlyList<Product>> GetAllProductsAsync(string? category)
        {
            var query = _context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                query = query.Where(x => x.Category == category);
            }

            var products = await query
                .Include(x => x.Image)
                .Include(x => x.Includes)
                .Include(x => x.Gallery.First)
                .Include(x => x.Gallery.Second)
                .Include(x => x.Gallery.Third)
                .Include(x => x.Others)
                .ThenInclude(x => x.Image)
                .AsSplitQuery()
                .OrderByDescending(x => x.Name)
                .ToListAsync();

            return products;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products
                .Include(x => x.Image)
                .Include(x => x.Includes)
                .Include(x => x.Gallery.First)
                .Include(x => x.Gallery.Second)
                .Include(x => x.Gallery.Third)
                .Include(x => x.Others)
                .ThenInclude(x => x.Image)
                .AsSplitQuery()
                .OrderByDescending(x => x.Name)
                .FirstOrDefaultAsync(x => x.Id == id);
            
            return product;
        }
    }
}
