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
    public class IncludeConfiguration : IEntityTypeConfiguration<Include>
    {
        public void Configure(EntityTypeBuilder<Include> builder)
        {
            builder.Property(i => i.Id).IsRequired();
            builder.Property(i => i.Quantity).IsRequired();
            builder.Property(i => i.Item).IsRequired()
                .HasMaxLength(100);
        }
    }
}
