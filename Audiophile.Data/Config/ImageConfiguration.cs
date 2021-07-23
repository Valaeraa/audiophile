using Audiophile.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Audiophile.Data.Config
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(i => i.Id).IsRequired();
            builder.Property(i => i.Mobile).IsRequired();
            builder.Property(i => i.Tablet).IsRequired();
            builder.Property(i => i.Desktop).IsRequired();
        }
    }
}
