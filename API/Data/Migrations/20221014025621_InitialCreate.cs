using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    QuantityInStock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 1, "Angular", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Angular Speedster Board 2000", "/images/products/sb-ang1.png", 20000L, 100, "Boards" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 2, "Angular", "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "Green Angular Board 3000", "/images/products/sb-ang2.png", 15000L, 100, "Boards" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 3, "NetCore", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Core Board Speed Rush 3", "/images/products/sb-core1.png", 18000L, 100, "Boards" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 4, "NetCore", "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Net Core Super Board", "/images/products/sb-core2.png", 30000L, 100, "Boards" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 5, "React", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "React Board Super Whizzy Fast", "/images/products/sb-react1.png", 25000L, 100, "Boards" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 6, "TypeScript", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Typescript Entry Board", "/images/products/sb-ts1.png", 12000L, 100, "Boards" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 7, "NetCore", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Core Blue Hat", "/images/products/hat-core1.png", 1000L, 100, "Hats" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 8, "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Green React Woolen Hat", "/images/products/hat-react1.png", 8000L, 100, "Hats" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 9, "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Purple React Woolen Hat", "/images/products/hat-react2.png", 1500L, 100, "Hats" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 10, "VS Code", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Blue Code Gloves", "/images/products/glove-code1.png", 1800L, 100, "Gloves" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 11, "VS Code", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Green Code Gloves", "/images/products/glove-code2.png", 1500L, 100, "Gloves" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 12, "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Purple React Gloves", "/images/products/glove-react1.png", 1600L, 100, "Gloves" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 13, "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Green React Gloves", "/images/products/glove-react2.png", 1400L, 100, "Gloves" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 14, "Redis", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Redis Red Boots", "/images/products/boot-redis1.png", 25000L, 100, "Boots" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 15, "NetCore", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Core Red Boots", "/images/products/boot-core2.png", 18999L, 100, "Boots" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 16, "NetCore", "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Core Purple Boots", "/images/products/boot-core1.png", 19999L, 100, "Boots" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 17, "Angular", "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.", "Angular Purple Boots", "/images/products/boot-ang2.png", 15000L, 100, "Boots" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[] { 18, "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", "/images/products/boot-ang1.png", 18000L, 100, "Boots" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
