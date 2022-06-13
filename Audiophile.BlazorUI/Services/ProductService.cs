using Audiophile.BlazorUI.Models;
using System.Text.Json;

namespace Audiophile.BlazorUI.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;

        public ProductService(HttpClient client)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<Product> GetProductById(int id)
        {
            var response = await _client.GetAsync($"api/products/{id}");
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var product = JsonSerializer.Deserialize<Product>(content, _options);

                return product;
            }
            else
            {
                throw new ApplicationException(content);
            }
        }

        public async Task<Product> GetProductBySlug(string slug)
        {
            var response = await _client.GetAsync($"api/products/{slug}");
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var product = JsonSerializer.Deserialize<Product>(content, _options);

                return product;
            }
            else
            {
                throw new ApplicationException(content);
            }
        }

        public async Task<List<Product>> GetProducts(string category = "")
        {
            var response = await _client.GetAsync($"api/products?category={category}");
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var products = JsonSerializer.Deserialize<List<Product>>(content, _options);

                return products;
            }
            else
            {
                throw new ApplicationException(content);
            }
        }
    }
}
