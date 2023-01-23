using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.CategoryID);

            builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(30);

            builder.HasMany(c => c.Foods)
                .WithOne(f=>f.Category)
                .HasForeignKey(f=>f.CategoryId); 
        }
    }
}
