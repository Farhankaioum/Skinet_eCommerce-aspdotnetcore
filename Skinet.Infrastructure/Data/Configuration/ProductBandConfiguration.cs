using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skinet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skinet.Infrastructure.Data.Configuration
{
    public class ProductBandConfiguration : IEntityTypeConfiguration<ProductBand>
    {
        public void Configure(EntityTypeBuilder<ProductBand> builder)
        {
            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(120);
        }
    }
}
