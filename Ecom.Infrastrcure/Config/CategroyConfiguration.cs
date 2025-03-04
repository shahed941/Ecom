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
    internal class CategroyConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Id).IsRequired();
        }
    }
}
