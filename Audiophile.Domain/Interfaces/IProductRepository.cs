using Audiophile.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Audiophile.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<IReadOnlyList<Product>> GetHeadphones();
    }
}
