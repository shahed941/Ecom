using Ecom.Core.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastrcure.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.Property(x => x.ProductName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.ProductDescription).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}
