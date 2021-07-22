using Audiophile.Data;
using Audiophile.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Audiophile.API.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
