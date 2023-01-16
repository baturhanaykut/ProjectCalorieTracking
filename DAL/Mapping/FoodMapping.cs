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
    public class FoodMapping : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Foods");

            builder.HasKey(f => f.FoodID);

            builder.Property(f => f.FoodName)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnType("nvarchar");

            builder.Property(f => f.Calorie)
                .IsRequired()
                .HasColumnType("decimal")
                .HasPrecision(5, 2);

            builder.Property(f => f.ImagePath)
                .IsRequired()
                .HasColumnType("nvarchar");




            //builder.HasOne(f => f.Category)
            //    .WithMany(c => c.Foods)
            //    .HasForeignKey(f => f.CategoryId);
        }
    }
}
