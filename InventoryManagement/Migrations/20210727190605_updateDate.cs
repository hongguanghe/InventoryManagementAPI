using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Migrations
{
    public partial class updateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 2, 12, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(5476), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 8, 31, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6803), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2021, 11, 4, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6813), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 4,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 2, 12, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6815), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 8, 31, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6817), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2021, 11, 4, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6819), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 7,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 2, 12, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6821), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 8,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 8, 31, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6823), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 9,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2021, 11, 4, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6825), new DateTime(2021, 7, 27, 19, 6, 4, 678, DateTimeKind.Utc).AddTicks(6826) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 1, 17, 457, DateTimeKind.Local).AddTicks(7826), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 8, 26, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4600), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2021, 10, 30, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4619), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 4,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4624), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 5,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 8, 26, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4630), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 6,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2021, 10, 30, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4635), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 7,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 2, 7, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4640), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 8,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2022, 8, 26, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4644), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 9,
                columns: new[] { "ExpirationDate", "PurchasedDate" },
                values: new object[] { new DateTime(2021, 10, 30, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4649), new DateTime(2021, 7, 22, 13, 1, 17, 466, DateTimeKind.Local).AddTicks(4652) });
        }
    }
}
