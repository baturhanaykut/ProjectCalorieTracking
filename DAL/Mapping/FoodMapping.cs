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
                .HasColumnType("decimal(5,2)");

            builder.Property(f => f.ImagePath)
                .IsRequired();
                

            builder.Property(f => f.Porsion)
                .IsRequired();

            builder.Property(f => f.Amount)
                .IsRequired()
                .HasColumnType("decimal(5,2)");


        }
    }
}
