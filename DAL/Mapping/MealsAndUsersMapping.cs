using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace DAL.Mapping;

public class MealsAndUsersMapping:IEntityTypeConfiguration<MealsAndUsers>
{
    public void Configure(EntityTypeBuilder<MealsAndUsers> builder)
    {
        builder.HasKey(mu => new { mu.MealID, mu.UserID });
    }
}