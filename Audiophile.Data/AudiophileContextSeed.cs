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
                var jsonData = File.ReadAllText("../Audiophile.Data/SeedData/data.json");
                var products = JsonSerializer.Deserialize<List<Product>>(jsonData);
                var images = new List<Image>();
                var includes = new List<Include>();
                var galleries = new List<Gallery>();
                var others = new List<Other>();

                foreach (var item in products)
                {
                    images.Add(item.Image);
                    includes.AddRange(item.Includes);
                    galleries.Add(item.Gallery);
                    others.AddRange(item.Others);
                }

                if (!context.Images.Any())
                {
                    foreach (var image in images)
                    {
                        context.Images.Add(image);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Includes.Any())
                {
                    foreach (var include in includes)
                    {
                        context.Includes.Add(include);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Galleries.Any())
                {
                    foreach (var gallery in galleries)
                    {
                        context.Galleries.Add(gallery);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Others.Any())
                {
                    foreach (var other in others)
                    {
                        context.Others.Add(other);
                    }

                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
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
