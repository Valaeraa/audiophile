using Audiophile.BlazorUI.Models;

namespace Audiophile.BlazorUI.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts(string category);
        Task<Product> GetProductById(int id);
        Task<Product> GetProductBySlug(string slug);
    }
}
