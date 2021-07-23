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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Slug).IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.Name).IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.Category).IsRequired();
            builder.Property(p => p.New).IsRequired();
            builder.Property(p => p.Price).IsRequired()
                .HasColumnType("decimal(18,2)");
            builder.Property(p => p.Description).IsRequired()
                .HasMaxLength(2000);
            builder.Property(p => p.Features).IsRequired()
                .HasMaxLength(2000);
            builder.Property(p => p.Includes).IsRequired();
            builder.Property(p => p.Gallery).IsRequired();
            builder.Property(p => p.Others).IsRequired();

            builder.HasOne(p => p.Image).WithMany()
                .HasForeignKey(p => p.ImageId);

            builder.HasOne(p => p.Includes).WithMany();

            builder.HasOne(p => p.Gallery).WithMany()
                .HasForeignKey(p => p.GalleryId);

            builder.HasOne(p => p.Others).WithMany();
        }
    }
}
