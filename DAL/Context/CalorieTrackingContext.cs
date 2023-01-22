using DAL.Mapping;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class CalorieTrackingContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProjectCalorieTracking-1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new FoodMapping());
            modelBuilder.ApplyConfiguration(new MealMapping());
            modelBuilder.ApplyConfiguration(new UserMapping());

            //modelBuilder.Entity<Category>().HasData(
            //    new Category { CategoryID = 1, CategoryName = "Et Ürünleri" },
            //    new Category { CategoryID = 2, CategoryName = "Süt Ürünleri" });

            //modelBuilder.Entity<Food>().HasData(
            //new Food {Calorie = 200,CategoryId = 1,FoodID = 1,FoodName = "Biftek", ImagePath = @"‪C:\Users\batur\Desktop\Calori Programı Resim\Et Dürüm.jpg" });

        }
    }
}
