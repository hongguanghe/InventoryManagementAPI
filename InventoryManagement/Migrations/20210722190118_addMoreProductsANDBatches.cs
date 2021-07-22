using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Migrations
{
    public partial class addMoreProductsANDBatches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "PurchasedDate", "Quantities" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 1, 17, 457, DateTimeKind.Local).AddTicks(7826), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(3891), 500 });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "PurchasedDate", "Quantities" },
                values: new object[] { new DateTime(2022, 8, 26, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4600), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4615), 20 });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "PurchasedDate", "Quantities" },
                values: new object[] { new DateTime(2021, 10, 30, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4619), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4621), 50 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Category", "Location", "Name", "OnSale", "Price" },
                values: new object[,]
                {
                    { 2, "BrandB", "Electronics", "A2", "Electronics Example Product", false, 99.980000000000004 },
                    { 3, "BrandC", "Home", "C8", "Water Bottle", true, 25.98 }
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "Cost", "ExpirationDate", "Manufacturer", "ProductId", "PurchasedDate", "Quantities" },
                values: new object[,]
                {
                    { 4, 9.0, new DateTime(2022, 2, 7, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4624), "E1 Inc.", 2, new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4627), 533 },
                    { 5, 18.0, new DateTime(2022, 8, 26, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4630), "E1 Inc.", 2, new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4632), 66 },
                    { 6, 759.5, new DateTime(2021, 10, 30, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4635), "E1 Inc.", 2, new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4637), 80 },
                    { 7, 22.030000000000001, new DateTime(2022, 2, 7, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4640), "Bottle Inc", 3, new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4642), 500 },
                    { 8, 29.879999999999999, new DateTime(2022, 8, 26, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4644), "Bottle Inc", 3, new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4647), 20 },
                    { 9, 18.550000000000001, new DateTime(2021, 10, 30, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4649), "Bottle Inc", 3, new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4652), 50 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "PurchasedDate", "Quantities" },
                values: new object[] { new DateTime(2022, 2, 7, 10, 35, 20, 642, DateTimeKind.Local).AddTicks(7289), new DateTime(2021, 7, 22, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3200), 200 });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "PurchasedDate", "Quantities" },
                values: new object[] { new DateTime(2022, 8, 26, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3914), new DateTime(2021, 7, 22, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3930), 200 });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "PurchasedDate", "Quantities" },
                values: new object[] { new DateTime(2021, 10, 30, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3935), new DateTime(2021, 7, 22, 10, 35, 20, 649, DateTimeKind.Local).AddTicks(3938), 200 });
        }
    }
}
