using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JDSExpertClone.Migrations
{
    /// <inheritdoc />
    public partial class FinalJDSUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "JDS Coffee");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Strong and Bold Coffee", "https://images.unsplash.com/photo-1510591509098-f4fdc6d0ff04?w=400", "JDS Espresso", 180m },
                    { 2, 1, "Sweet Caramel Bliss", "https://images.unsplash.com/photo-1485808191679-5f86510681a2?w=400", "Caramel Latte", 250m },
                    { 3, 1, "Freshly Brewed Ice Coffee", "https://images.unsplash.com/photo-1517701604599-bb29b565090c?w=400", "Iced Americano", 200m },
                    { 4, 2, "Organic Fresh Mango", "https://images.unsplash.com/photo-1546173159-315724a31696?w=400", "Mango Blast", 120m },
                    { 5, 2, "Natural Watermelon Squeeze", "https://images.unsplash.com/photo-1543158181-e6f9f697ce4b?w=400", "Watermelon Cooler", 100m },
                    { 6, 2, "High Vitamin C Orange", "https://images.unsplash.com/photo-1624517452488-04869289c4ca?w=400", "Orange Squeeze", 150m },
                    { 7, 3, "Extra Chocolate Chips", "https://images.unsplash.com/photo-1499636136210-6f4ee915583e?w=400", "Choco Chip Cookie", 60m },
                    { 8, 3, "Crunchy Almonds Butter", "https://images.unsplash.com/photo-1558961363-fa8fdf82db35?w=400", "Almond Crunch", 80m },
                    { 9, 3, "Healthy Soft Oats", "https://images.unsplash.com/photo-1590080875515-8a03b1447d1a?w=400", "Oatmeal Raisin", 55m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Name" },
                values: new object[] { "coffee.png", "Coffee" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "juice.png");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "cookies.png");
        }
    }
}
