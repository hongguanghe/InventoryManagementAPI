using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Migrations
{
    public partial class SeedingBatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantities",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Category", "Location", "Name", "OnSale", "Price" },
                values: new object[] { 1, "BrandA", "Fashion", "A8", "Product A", true, 9.0 });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "Cost", "ExpirationDate", "Manufacturer", "ProductId", "PurchasedDate", "Quantities" },
                values: new object[] { 1, 9.0, new DateTime(2022, 2, 7, 10, 35, 20, 642, DateTimeKind.Local).AddTicks(7289), "M1", 1, new DateTime(2021, 7, 22, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3200), 200 });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "Cost", "ExpirationDate", "Manufacturer", "ProductId", "PurchasedDate", "Quantities" },
                values: new object[] { 2, 8.0, new DateTime(2022, 8, 26, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3914), "M1", 1, new DateTime(2021, 7, 22, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3930), 200 });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "Cost", "ExpirationDate", "Manufacturer", "ProductId", "PurchasedDate", "Quantities" },
                values: new object[] { 3, 7.0, new DateTime(2021, 10, 30, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3935), "M1", 1, new DateTime(2021, 7, 22, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3938), 200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Quantities",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
