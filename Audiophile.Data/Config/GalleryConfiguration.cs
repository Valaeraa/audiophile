using Audiophile.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audiophile.Data.Config
{
    public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            builder.Property(g => g.Id).IsRequired();
            builder.Property(g => g.First).IsRequired();
            builder.Property(g => g.Second).IsRequired();
            builder.Property(g => g.Third).IsRequired();
        }
    }
}
