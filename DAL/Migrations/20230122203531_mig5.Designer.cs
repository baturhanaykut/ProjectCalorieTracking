﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(CalorieTrackingContext))]
    [Migration("20230122203531_mig5")]
    partial class mig5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Entity.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Et Ürünleri"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Süt Ürünleri"
                        });
                });

            modelBuilder.Entity("Entities.Entity.Food", b =>
                {
                    b.Property<int>("FoodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodID"), 1L, 1);

                    b.Property<decimal>("Calorie")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Porsion")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("FoodID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods", (string)null);

                    b.HasData(
                        new
                        {
                            FoodID = 1,
                            Calorie = 200m,
                            CategoryId = 1,
                            FoodName = "Biftek",
                            ImagePath = "‪C:\\Users\\batur\\Desktop\\Calori Programı Resim\\Et Dürüm.jpg",
                            Porsion = "Piece"
                        });
                });

            modelBuilder.Entity("Entities.Entity.Meal", b =>
                {
                    b.Property<int>("MealID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MealID"), 1L, 1);

                    b.Property<DateTime>("MealDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("TotalMealCalories")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MealID");

                    b.HasIndex("UserId");

                    b.ToTable("Meals", (string)null);
                });

            modelBuilder.Entity("Entities.Entity.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UserBirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserGender")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<decimal>("UserHeight")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("UserMail")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("UserWeight")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("UserID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.Property<int>("FoodsFoodID")
                        .HasColumnType("int");

                    b.Property<int>("MealsMealID")
                        .HasColumnType("int");

                    b.HasKey("FoodsFoodID", "MealsMealID");

                    b.HasIndex("MealsMealID");

                    b.ToTable("FoodMeal");
                });

            modelBuilder.Entity("Entities.Entity.Food", b =>
                {
                    b.HasOne("Entities.Entity.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Entity.Meal", b =>
                {
                    b.HasOne("Entities.Entity.User", "User")
                        .WithMany("Meals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.HasOne("Entities.Entity.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsFoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entity.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsMealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Entity.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("Entities.Entity.User", b =>
                {
                    b.Navigation("Meals");
                });
#pragma warning restore 612, 618
        }
    }
}
