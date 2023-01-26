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
    [Migration("20230125213725_mig1")]
    partial class mig1
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
                            CategoryName = "Et ve Tavuk Yemekleri"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Sebze Yemekleri"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Zeytin Yağlı Yemekler"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Balık ve Deniz Ürünleri"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Çorbalar"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Makarna ve Pilav"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Salata - Turşu"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Ekmekler"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Sıcak-Soğuk İçecekler"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Tatlılar"
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
                            Calorie = 242m,
                            CategoryId = 1,
                            FoodName = "Bonfile",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 2,
                            Calorie = 219m,
                            CategoryId = 1,
                            FoodName = "Kavurma",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 3,
                            Calorie = 290m,
                            CategoryId = 1,
                            FoodName = "Köfte",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 4,
                            Calorie = 225m,
                            CategoryId = 1,
                            FoodName = "Tavuk Izgara",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 5,
                            Calorie = 135m,
                            CategoryId = 1,
                            FoodName = "Hindi Göğüs(100 Gr)",
                            Porsion = "Gram"
                        },
                        new
                        {
                            FoodID = 6,
                            Calorie = 242m,
                            CategoryId = 2,
                            FoodName = "Bezelye",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 7,
                            Calorie = 243m,
                            CategoryId = 2,
                            FoodName = "Brokoli",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 8,
                            Calorie = 244m,
                            CategoryId = 2,
                            FoodName = "Domates",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 9,
                            Calorie = 245m,
                            CategoryId = 2,
                            FoodName = "Salatalık",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 10,
                            Calorie = 246m,
                            CategoryId = 2,
                            FoodName = "Enginar",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 11,
                            Calorie = 247m,
                            CategoryId = 2,
                            FoodName = "Mısır",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 12,
                            Calorie = 150m,
                            CategoryId = 3,
                            FoodName = "Taze Fasülye",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 13,
                            Calorie = 175m,
                            CategoryId = 3,
                            FoodName = "Yaprak Sarma",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 14,
                            Calorie = 200m,
                            CategoryId = 3,
                            FoodName = "Pırasa",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 15,
                            Calorie = 300m,
                            CategoryId = 4,
                            FoodName = "Hamsi Tava",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 16,
                            Calorie = 400m,
                            CategoryId = 4,
                            FoodName = "Levrak Izgara",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 17,
                            Calorie = 550m,
                            CategoryId = 4,
                            FoodName = "Kalamar Tava",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 18,
                            Calorie = 150m,
                            CategoryId = 5,
                            FoodName = "Mercimek",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 19,
                            Calorie = 155m,
                            CategoryId = 5,
                            FoodName = "Ezogelin",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 20,
                            Calorie = 355m,
                            CategoryId = 5,
                            FoodName = "Kelle - Paça",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 21,
                            Calorie = 300m,
                            CategoryId = 5,
                            FoodName = "İşkembe",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 22,
                            Calorie = 125m,
                            CategoryId = 5,
                            FoodName = "Tarhana",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 23,
                            Calorie = 150m,
                            CategoryId = 6,
                            FoodName = "Pirinç Pilavı",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 24,
                            Calorie = 100m,
                            CategoryId = 6,
                            FoodName = "Bulgur Pilavı",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 25,
                            Calorie = 155m,
                            CategoryId = 6,
                            FoodName = "Nohutlu Pirinç Pilavı",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 26,
                            Calorie = 200m,
                            CategoryId = 6,
                            FoodName = "Tavuklu Pirinç Pilavı",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 27,
                            Calorie = 120m,
                            CategoryId = 6,
                            FoodName = "Sebzeli Bulgur Pilavı",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 28,
                            Calorie = 120m,
                            CategoryId = 6,
                            FoodName = "Sade Makarna",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 29,
                            Calorie = 120m,
                            CategoryId = 6,
                            FoodName = "Fettucini Alfredo",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 30,
                            Calorie = 250m,
                            CategoryId = 7,
                            FoodName = "Sezar",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 31,
                            Calorie = 120m,
                            CategoryId = 7,
                            FoodName = "Çoban Salata",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 32,
                            Calorie = 150m,
                            CategoryId = 7,
                            FoodName = "Mevsim Salata",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 33,
                            Calorie = 300m,
                            CategoryId = 7,
                            FoodName = "Gavurdağ Salata",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 34,
                            Calorie = 450m,
                            CategoryId = 7,
                            FoodName = "Rus Salatası",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 35,
                            Calorie = 450m,
                            CategoryId = 8,
                            FoodName = "Beyaz Ekmeği",
                            Porsion = "Slice"
                        },
                        new
                        {
                            FoodID = 36,
                            Calorie = 450m,
                            CategoryId = 8,
                            FoodName = "Kepekli Ekmeği",
                            Porsion = "Slice"
                        },
                        new
                        {
                            FoodID = 37,
                            Calorie = 450m,
                            CategoryId = 8,
                            FoodName = "Çavdar Ekmeği",
                            Porsion = "Slice"
                        },
                        new
                        {
                            FoodID = 38,
                            Calorie = 250m,
                            CategoryId = 9,
                            FoodName = "Pepsi",
                            Porsion = "Millilitre"
                        },
                        new
                        {
                            FoodID = 39,
                            Calorie = 250m,
                            CategoryId = 9,
                            FoodName = "Sprite",
                            Porsion = "Millilitre"
                        },
                        new
                        {
                            FoodID = 40,
                            Calorie = 250m,
                            CategoryId = 9,
                            FoodName = "Fanta",
                            Porsion = "Millilitre"
                        },
                        new
                        {
                            FoodID = 41,
                            Calorie = 50m,
                            CategoryId = 9,
                            FoodName = "Su",
                            Porsion = "Millilitre"
                        },
                        new
                        {
                            FoodID = 42,
                            Calorie = 55m,
                            CategoryId = 9,
                            FoodName = "Çay",
                            Porsion = "Millilitre"
                        },
                        new
                        {
                            FoodID = 43,
                            Calorie = 60m,
                            CategoryId = 9,
                            FoodName = "Türk Kahvesi",
                            Porsion = "Millilitre"
                        },
                        new
                        {
                            FoodID = 44,
                            Calorie = 650m,
                            CategoryId = 10,
                            FoodName = "Baklava",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 45,
                            Calorie = 750m,
                            CategoryId = 10,
                            FoodName = "Tulumba",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 46,
                            Calorie = 800m,
                            CategoryId = 10,
                            FoodName = "Katmer",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 48,
                            Calorie = 450m,
                            CategoryId = 10,
                            FoodName = "Sütlaç",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 49,
                            Calorie = 450m,
                            CategoryId = 10,
                            FoodName = "Sufle",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 50,
                            Calorie = 450m,
                            CategoryId = 10,
                            FoodName = "Waffle",
                            Porsion = "Piece"
                        },
                        new
                        {
                            FoodID = 51,
                            Calorie = 450m,
                            CategoryId = 10,
                            FoodName = "Tiremusu",
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