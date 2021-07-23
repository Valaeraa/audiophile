using Audiophile.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Audiophile.Data
{
    public class AudiophileContext : DbContext
    {
        public AudiophileContext(DbContextOptions<AudiophileContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Include> Includes { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Other> Others { get; set; }
    }
}
