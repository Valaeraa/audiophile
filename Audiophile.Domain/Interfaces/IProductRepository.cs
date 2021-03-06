using Audiophile.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Audiophile.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetAllProductsAsync(string? category);
        Task<Product> GetProductBySlugAsync(string slug);
    }
}
