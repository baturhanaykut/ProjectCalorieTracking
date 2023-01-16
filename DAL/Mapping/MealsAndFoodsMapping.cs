using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Mapping;

public class MealsAndFoodsMapping:IEntityTypeConfiguration<MealsAndFoods>
{
    public void Configure(EntityTypeBuilder<MealsAndFoods> builder)
    {
        
        builder.HasKey(mf => new { mf.MealID, mf.FoodID });
    }
}