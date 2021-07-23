using Audiophile.Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Audiophile.Data
{
    public class AudiophileContextSeed
    {
        public static async Task SeedDataAsync(AudiophileContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Products.Any())
                {
                    var jsonData = File.ReadAllText("../Audiophile.Data/SeedData/data.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(jsonData);

                    foreach (var product in products)
                    {
                        context.Products.Add(product);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<AudiophileContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
