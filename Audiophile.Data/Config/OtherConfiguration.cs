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
    public class OtherConfiguration : IEntityTypeConfiguration<Other>
    {
        public void Configure(EntityTypeBuilder<Other> builder)
        {
            builder.Property(o => o.Id).IsRequired();
            builder.Property(o => o.Slug).IsRequired()
                .HasMaxLength(100);
            builder.Property(o => o.Name).IsRequired()
                .HasMaxLength(100);
            builder.Property(o => o.Image).IsRequired();
        }
    }
}
