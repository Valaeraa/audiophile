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
    }
}
