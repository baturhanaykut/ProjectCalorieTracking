using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserSurname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserMail = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    UserBirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserWeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UserHeight = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UserGender = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Calorie = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMealCalories = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealID);
                    table.ForeignKey(
                        name: "FK_Meals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMeal",
                columns: table => new
                {
                    FoodsFoodID = table.Column<int>(type: "int", nullable: false),
                    MealsMealID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeal", x => new { x.FoodsFoodID, x.MealsMealID });
                    table.ForeignKey(
                        name: "FK_FoodMeal_Foods_FoodsFoodID",
                        column: x => x.FoodsFoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeal_Meals_MealsMealID",
                        column: x => x.MealsMealID,
                        principalTable: "Meals",
                        principalColumn: "MealID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Et ve Tavuk Yemekleri" },
                    { 2, "Sebze Yemekleri" },
                    { 3, "Zeytin Yağlı Yemekler" },
                    { 4, "Balık ve Deniz Ürünleri" },
                    { 5, "Çorbalar" },
                    { 6, "Makarna ve Pilav" },
                    { 7, "Salata - Turşu" },
                    { 8, "Ekmekler" },
                    { 9, "Sıcak-Soğuk İçecekler" },
                    { 10, "Tatlılar" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryId", "FoodName", "ImagePath", "Porsion" },
                values: new object[,]
                {
                    { 1, 242m, 1, "Bonfile", null, "Piece" },
                    { 2, 219m, 1, "Kavurma", null, "Piece" },
                    { 3, 290m, 1, "Köfte", null, "Piece" },
                    { 4, 225m, 1, "Tavuk Izgara", null, "Piece" },
                    { 5, 135m, 1, "Hindi Göğüs(100 Gr)", null, "Gram" },
                    { 6, 242m, 2, "Bezelye", null, "Piece" },
                    { 7, 243m, 2, "Brokoli", null, "Piece" },
                    { 8, 244m, 2, "Domates", null, "Piece" },
                    { 9, 245m, 2, "Salatalık", null, "Piece" },
                    { 10, 246m, 2, "Enginar", null, "Piece" },
                    { 11, 247m, 2, "Mısır", null, "Piece" },
                    { 12, 150m, 3, "Taze Fasülye", null, "Piece" },
                    { 13, 175m, 3, "Yaprak Sarma", null, "Piece" },
                    { 14, 200m, 3, "Pırasa", null, "Piece" },
                    { 15, 300m, 4, "Hamsi Tava", null, "Piece" },
                    { 16, 400m, 4, "Levrak Izgara", null, "Piece" },
                    { 17, 550m, 4, "Kalamar Tava", null, "Piece" },
                    { 18, 150m, 5, "Mercimek", null, "Piece" },
                    { 19, 155m, 5, "Ezogelin", null, "Piece" },
                    { 20, 355m, 5, "Kelle - Paça", null, "Piece" },
                    { 21, 300m, 5, "İşkembe", null, "Piece" },
                    { 22, 125m, 5, "Tarhana", null, "Piece" },
                    { 23, 150m, 6, "Pirinç Pilavı", null, "Piece" },
                    { 24, 100m, 6, "Bulgur Pilavı", null, "Piece" },
                    { 25, 155m, 6, "Nohutlu Pirinç Pilavı", null, "Piece" },
                    { 26, 200m, 6, "Tavuklu Pirinç Pilavı", null, "Piece" },
                    { 27, 120m, 6, "Sebzeli Bulgur Pilavı", null, "Piece" },
                    { 28, 120m, 6, "Sade Makarna", null, "Piece" },
                    { 29, 120m, 6, "Fettucini Alfredo", null, "Piece" },
                    { 30, 250m, 7, "Sezar", null, "Piece" },
                    { 31, 120m, 7, "Çoban Salata", null, "Piece" },
                    { 32, 150m, 7, "Mevsim Salata", null, "Piece" },
                    { 33, 300m, 7, "Gavurdağ Salata", null, "Piece" },
                    { 34, 450m, 7, "Rus Salatası", null, "Piece" },
                    { 35, 450m, 8, "Beyaz Ekmeği", null, "Slice" },
                    { 36, 450m, 8, "Kepekli Ekmeği", null, "Slice" },
                    { 37, 450m, 8, "Çavdar Ekmeği", null, "Slice" },
                    { 38, 250m, 9, "Pepsi", null, "Millilitre" },
                    { 39, 250m, 9, "Sprite", null, "Millilitre" },
                    { 40, 250m, 9, "Fanta", null, "Millilitre" },
                    { 41, 50m, 9, "Su", null, "Millilitre" },
                    { 42, 55m, 9, "Çay", null, "Millilitre" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryId", "FoodName", "ImagePath", "Porsion" },
                values: new object[,]
                {
                    { 43, 60m, 9, "Türk Kahvesi", null, "Millilitre" },
                    { 44, 650m, 10, "Baklava", null, "Piece" },
                    { 45, 750m, 10, "Tulumba", null, "Piece" },
                    { 46, 800m, 10, "Katmer", null, "Piece" },
                    { 48, 450m, 10, "Sütlaç", null, "Piece" },
                    { 49, 450m, 10, "Sufle", null, "Piece" },
                    { 50, 450m, 10, "Waffle", null, "Piece" },
                    { 51, 450m, 10, "Tiremusu", null, "Piece" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeal_MealsMealID",
                table: "FoodMeal",
                column: "MealsMealID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserId",
                table: "Meals",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodMeal");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
