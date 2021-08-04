using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryManagement.Migrations
{
    public partial class updatedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OnSale = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantities = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                    table.ForeignKey(
                        name: "FK_Batches_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Category", "Location", "Name", "OnSale", "Price" },
                values: new object[,]
                {
                    { 1, "ground", "Other", "A7", "Alice blue clock", false, 23.559999999999999 },
                    { 28, "post", "Electronics", "A7", "Aqua radio", false, 77.040000000000006 },
                    { 29, "mere", "Fashion", "A8", "Antique white bow", true, 29.649999999999999 },
                    { 30, "cover", "Electronics", "A8", "Amber tooth picks", true, 98.290000000000006 },
                    { 31, "agricultural", "Pet", "A6", "Arylide yellow mouse pad", true, 13.630000000000001 },
                    { 32, "border", "Beauty", "A5", "Air Force blue canvas", true, 61.049999999999997 },
                    { 33, "greatest", "Other", "A4", "American rose bow", true, 87.340000000000003 },
                    { 34, "suppose", "Electronics", "A7", "Antique fuchsia wagon", true, 96.760000000000005 },
                    { 35, "greatest", "Electronics", "A1", "Air Force blue mouse pad", true, 13.210000000000001 },
                    { 36, "agricultural", "Outdoor", "A5", "Alice blue street lights", false, 59.119999999999997 },
                    { 37, "wonderful", "Pet", "A7", "Army green door", true, 38.450000000000003 },
                    { 38, "mark", "Pet", "A8", "Alice blue tooth picks", true, 66.609999999999999 },
                    { 39, "post", "Pet", "A7", "Air Force blue rug", true, 47.780000000000001 },
                    { 40, "circumstance", "Pet", "A0", "Apple green bag", false, 3.1099999999999999 },
                    { 41, "boom", "Other", "A0", "Antique fuchsia radio", true, 72.010000000000005 },
                    { 42, "mark", "Electronics", "A2", "Antique fuchsia candy wrapper", true, 74.530000000000001 },
                    { 43, "adapt", "Fashion", "A7", "Asparagus street lights", true, 57.619999999999997 },
                    { 44, "system", "Fashion", "A5", "Antique white bag", false, 60.899999999999999 },
                    { 45, "mark", "Electronics", "A4", "Apple green clay pot", true, 12.59 },
                    { 46, "dress", "Pet", "A6", "Asparagus canvas", false, 17.859999999999999 },
                    { 47, "detect", "Pet", "A9", "Amber mouse pad", false, 69.650000000000006 },
                    { 48, "agricultural", "Pet", "A2", "Antique fuchsia street lights", true, 45.259999999999998 },
                    { 27, "sigh", "Electronics", "A6", "Apricot street lights", true, 34.409999999999997 },
                    { 26, "comparison", "Pet", "A9", "Army green clay pot", false, 19.649999999999999 },
                    { 25, "testimony", "Fashion", "A7", "Antique fuchsia mouse pad", false, 19.23 },
                    { 24, "adapt", "Fashion", "A0", "Apricot model car", true, 99.25 },
                    { 2, "board", "Beauty", "A9", "Arylide yellow spoon", false, 44.0 },
                    { 3, "boom", "Outdoor", "A7", "Alice blue bag", true, 47.859999999999999 },
                    { 4, "precisely", "Pet", "A4", "Army green video games", true, 38.799999999999997 },
                    { 5, "wonderful", "Fashion", "A4", "Alice blue perfume", false, 8.0999999999999996 },
                    { 6, "software", "Other", "A9", "Alizarin crimson radio", false, 22.489999999999998 },
                    { 7, "circle", "Outdoor", "A0", "Amaranth bed", true, 61.100000000000001 },
                    { 8, "sanction", "Beauty", "A8", "Army green soap", true, 59.859999999999999 },
                    { 9, "sanction", "Pet", "A1", "Alizarin crimson tooth picks", false, 32.549999999999997 },
                    { 10, "system", "Beauty", "A6", "Apple green deodorant", false, 62.130000000000003 },
                    { 11, "egg", "Outdoor", "A0", "Antique fuchsia clay pot", true, 86.099999999999994 },
                    { 49, "contact", "Home", "A1", "Aquamarine wagon", false, 82.370000000000005 },
                    { 12, "married", "Pet", "A0", "Anti-flash white bow", false, 21.059999999999999 },
                    { 14, "cover", "Beauty", "A2", "Aqua toothbrush", false, 61.549999999999997 },
                    { 15, "system", "Home", "A8", "Alice blue street lights", false, 39.32 },
                    { 16, "egg", "Fashion", "A7", "Amber sharpie", true, 32.979999999999997 },
                    { 17, "suppose", "Beauty", "A2", "Arylide yellow street lights", true, 71.760000000000005 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Category", "Location", "Name", "OnSale", "Price" },
                values: new object[,]
                {
                    { 18, "suppose", "Beauty", "A4", "Apple green canvas", true, 59.600000000000001 },
                    { 19, "contact", "Other", "A4", "Arylide yellow bed", true, 49.270000000000003 },
                    { 20, "impress", "Other", "A7", "Android Green bed", false, 80.989999999999995 },
                    { 21, "cast", "Beauty", "A1", "Asparagus apple", false, 72.219999999999999 },
                    { 22, "border", "Electronics", "A0", "Aqua pants", true, 65.510000000000005 },
                    { 23, "production", "Electronics", "A5", "Air Force blue purse", true, 4.04 },
                    { 13, "software", "Beauty", "A8", "Amethyst wagon", true, 16.77 },
                    { 50, "system", "Outdoor", "A6", "Almond eraser", false, 71.879999999999995 }
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "Cost", "ExpirationDate", "Manufacturer", "ProductId", "PurchasedDate", "Quantities" },
                values: new object[,]
                {
                    { 1, 71.150000000000006, new DateTime(2021, 8, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(3228), "cover", 1, new DateTime(2021, 7, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(3943), 71 },
                    { 89, 24.460000000000001, new DateTime(2022, 7, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4752), "detect", 39, new DateTime(2020, 8, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4753), 477 },
                    { 88, 72.909999999999997, new DateTime(2021, 10, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4749), "sigh", 39, new DateTime(2021, 5, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4750), 360 },
                    { 87, 99.870000000000005, new DateTime(2022, 7, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4744), "during", 38, new DateTime(2020, 8, 23, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4745), 342 },
                    { 86, 96.359999999999999, new DateTime(2023, 1, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4738), "boom", 37, new DateTime(2020, 2, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4739), 435 },
                    { 85, 99.870000000000005, new DateTime(2023, 7, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4736), "suppose", 37, new DateTime(2019, 8, 31, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4737), 315 },
                    { 84, 34.350000000000001, new DateTime(2021, 12, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4733), "mere", 37, new DateTime(2021, 3, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4734), 193 },
                    { 83, 69.219999999999999, new DateTime(2022, 10, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4728), "circumstance", 36, new DateTime(2020, 6, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4729), 62 },
                    { 82, 10.99, new DateTime(2022, 10, 20, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4725), "contact", 36, new DateTime(2020, 5, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4726), 225 },
                    { 81, 32.439999999999998, new DateTime(2022, 7, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4723), "comparison", 36, new DateTime(2020, 8, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4724), 414 },
                    { 80, 29.629999999999999, new DateTime(2021, 12, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4721), "married", 36, new DateTime(2021, 3, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4722), 356 },
                    { 79, 40.630000000000003, new DateTime(2021, 11, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4718), "post", 36, new DateTime(2021, 4, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4719), 440 },
                    { 78, 99.590000000000003, new DateTime(2022, 11, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4712), "independence", 35, new DateTime(2020, 4, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4713), 185 },
                    { 90, 34.630000000000003, new DateTime(2022, 6, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4754), "egg", 39, new DateTime(2020, 9, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4755), 398 },
                    { 77, 58.100000000000001, new DateTime(2022, 10, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4707), "production", 34, new DateTime(2020, 5, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4707), 65 },
                    { 75, 92.269999999999996, new DateTime(2021, 10, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4702), "circle", 34, new DateTime(2021, 6, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4703), 406 },
                    { 74, 60.57, new DateTime(2022, 4, 12, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4696), "suppose", 33, new DateTime(2020, 11, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4697), 98 },
                    { 73, 25.649999999999999, new DateTime(2023, 4, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4694), "during", 33, new DateTime(2019, 11, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4694), 235 },
                    { 72, 98.659999999999997, new DateTime(2022, 9, 3, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4686), "exactly", 32, new DateTime(2020, 7, 3, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4687), 187 },
                    { 71, 89.519999999999996, new DateTime(2022, 11, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4683), "during", 32, new DateTime(2020, 4, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4684), 114 },
                    { 70, 31.850000000000001, new DateTime(2023, 2, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4681), "mere", 32, new DateTime(2020, 1, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4682), 455 },
                    { 69, 28.640000000000001, new DateTime(2022, 3, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4679), "software", 32, new DateTime(2021, 1, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4680), 494 },
                    { 68, 91.909999999999997, new DateTime(2022, 7, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4644), "system", 31, new DateTime(2020, 9, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4645), 29 },
                    { 67, 15.57, new DateTime(2022, 6, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4641), "dress", 31, new DateTime(2020, 10, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4642), 202 },
                    { 66, 51.159999999999997, new DateTime(2022, 12, 31, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4639), "post", 31, new DateTime(2020, 3, 6, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4640), 393 },
                    { 65, 99.719999999999999, new DateTime(2022, 8, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4632), "expression", 30, new DateTime(2020, 7, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4633), 398 },
                    { 64, 68.859999999999999, new DateTime(2023, 5, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4630), "cover", 30, new DateTime(2019, 10, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4631), 235 },
                    { 76, 97.560000000000002, new DateTime(2021, 11, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4704), "cover", 34, new DateTime(2021, 4, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4705), 477 },
                    { 91, 14.699999999999999, new DateTime(2021, 11, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4756), "border", 39, new DateTime(2021, 4, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4757), 183 },
                    { 92, 80.549999999999997, new DateTime(2022, 5, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4761), "post", 40, new DateTime(2020, 10, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4762), 190 },
                    { 93, 29.18, new DateTime(2021, 11, 5, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4764), "expression", 40, new DateTime(2021, 5, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4765), 110 },
                    { 120, 21.84, new DateTime(2023, 2, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4857), "impress", 49, new DateTime(2020, 1, 31, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4858), 33 },
                    { 119, 68.090000000000003, new DateTime(2022, 5, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4855), "ground", 49, new DateTime(2020, 11, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4856), 410 },
                    { 118, 15.44, new DateTime(2023, 7, 20, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4852), "cast", 49, new DateTime(2019, 8, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4853), 392 },
                    { 117, 64.719999999999999, new DateTime(2022, 5, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4847), "expression", 48, new DateTime(2020, 10, 30, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4847), 305 },
                    { 116, 92.260000000000005, new DateTime(2022, 8, 30, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4841), "adapt", 47, new DateTime(2020, 7, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4842), 473 },
                    { 115, 20.77, new DateTime(2023, 4, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4839), "precisely", 47, new DateTime(2019, 11, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4840), 314 },
                    { 114, 79.599999999999994, new DateTime(2022, 9, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4833), "greatest", 46, new DateTime(2020, 7, 5, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4834), 422 },
                    { 113, 84.510000000000005, new DateTime(2021, 9, 22, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4831), "egg", 46, new DateTime(2021, 6, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4832), 251 },
                    { 112, 75.650000000000006, new DateTime(2022, 1, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4828), "agricultural", 46, new DateTime(2021, 2, 6, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4829), 486 },
                    { 111, 21.41, new DateTime(2022, 12, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4826), "dress", 46, new DateTime(2020, 3, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4827), 195 },
                    { 110, 68.689999999999998, new DateTime(2022, 11, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4823), "greatest", 46, new DateTime(2020, 4, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4824), 486 }
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "Cost", "ExpirationDate", "Manufacturer", "ProductId", "PurchasedDate", "Quantities" },
                values: new object[,]
                {
                    { 109, 37.340000000000003, new DateTime(2022, 1, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4818), "egg", 45, new DateTime(2021, 2, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4819), 70 },
                    { 108, 79.829999999999998, new DateTime(2022, 2, 20, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4812), "dress", 44, new DateTime(2021, 1, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4813), 490 },
                    { 107, 93.439999999999998, new DateTime(2021, 10, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4807), "comparison", 43, new DateTime(2021, 5, 12, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4808), 145 },
                    { 106, 30.170000000000002, new DateTime(2023, 4, 15, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4804), "independence", 43, new DateTime(2019, 11, 22, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4805), 194 },
                    { 105, 6.4400000000000004, new DateTime(2023, 1, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4802), "detect", 43, new DateTime(2020, 2, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4803), 432 },
                    { 104, 17.859999999999999, new DateTime(2023, 7, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4799), "expression", 43, new DateTime(2019, 8, 21, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4800), 243 },
                    { 103, 2.5099999999999998, new DateTime(2023, 7, 21, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4794), "dress", 42, new DateTime(2019, 8, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4795), 150 },
                    { 102, 17.18, new DateTime(2022, 9, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4791), "cover", 42, new DateTime(2020, 6, 12, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4792), 301 },
                    { 101, 17.420000000000002, new DateTime(2023, 1, 5, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4789), "impress", 42, new DateTime(2020, 3, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4790), 206 },
                    { 100, 52.119999999999997, new DateTime(2022, 12, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4787), "border", 42, new DateTime(2020, 3, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4787), 290 },
                    { 99, 85.239999999999995, new DateTime(2021, 11, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4784), "mark", 42, new DateTime(2021, 4, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4785), 168 },
                    { 98, 72.439999999999998, new DateTime(2022, 10, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4779), "sigh", 41, new DateTime(2020, 5, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4780), 107 },
                    { 97, 8.9399999999999995, new DateTime(2021, 8, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4777), "exactly", 41, new DateTime(2021, 7, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4778), 318 },
                    { 96, 22.34, new DateTime(2022, 3, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4774), "detect", 41, new DateTime(2020, 12, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4775), 356 },
                    { 95, 80.260000000000005, new DateTime(2022, 4, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4772), "comparison", 41, new DateTime(2020, 12, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4773), 138 },
                    { 94, 22.91, new DateTime(2021, 12, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4767), "board", 40, new DateTime(2021, 3, 21, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4767), 114 },
                    { 63, 38.170000000000002, new DateTime(2022, 6, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4628), "board", 30, new DateTime(2020, 9, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4629), 249 },
                    { 62, 95.989999999999995, new DateTime(2023, 2, 21, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4625), "precisely", 30, new DateTime(2020, 1, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4626), 102 },
                    { 61, 85.810000000000002, new DateTime(2022, 7, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4623), "border", 30, new DateTime(2020, 8, 23, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4624), 202 },
                    { 60, 40.670000000000002, new DateTime(2021, 9, 20, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4617), "system", 29, new DateTime(2021, 6, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4618), 203 },
                    { 28, 56.170000000000002, new DateTime(2022, 11, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4441), "egg", 11, new DateTime(2020, 4, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4442), 210 },
                    { 27, 79.209999999999994, new DateTime(2023, 5, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4438), "circumstance", 11, new DateTime(2019, 10, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4439), 452 },
                    { 26, 59.289999999999999, new DateTime(2021, 11, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4436), "board", 11, new DateTime(2021, 4, 22, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4437), 274 },
                    { 25, 27.25, new DateTime(2021, 9, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4433), "post", 11, new DateTime(2021, 6, 11, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4434), 489 },
                    { 24, 88.290000000000006, new DateTime(2021, 10, 20, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4428), "cast", 10, new DateTime(2021, 5, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4429), 265 },
                    { 23, 12.890000000000001, new DateTime(2022, 4, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4421), "system", 9, new DateTime(2020, 11, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4422), 189 },
                    { 22, 52.420000000000002, new DateTime(2022, 8, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4414), "sanction", 8, new DateTime(2020, 7, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4415), 426 },
                    { 21, 11.17, new DateTime(2022, 4, 5, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4411), "sigh", 8, new DateTime(2020, 12, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4413), 84 },
                    { 20, 95.790000000000006, new DateTime(2021, 9, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4409), "greatest", 8, new DateTime(2021, 6, 23, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4410), 387 },
                    { 19, 12.07, new DateTime(2022, 9, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4406), "production", 8, new DateTime(2020, 6, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4407), 32 },
                    { 18, 69.609999999999999, new DateTime(2022, 4, 30, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4396), "married", 6, new DateTime(2020, 11, 6, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4397), 115 },
                    { 17, 7.46, new DateTime(2023, 3, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4393), "detect", 6, new DateTime(2019, 12, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4394), 184 },
                    { 16, 84.489999999999995, new DateTime(2023, 1, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4387), "mere", 5, new DateTime(2020, 2, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4388), 183 },
                    { 15, 26.239999999999998, new DateTime(2022, 2, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4385), "precisely", 5, new DateTime(2021, 1, 30, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4386), 130 },
                    { 14, 85.260000000000005, new DateTime(2022, 7, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4382), "cast", 5, new DateTime(2020, 9, 2, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4383), 302 },
                    { 13, 52.119999999999997, new DateTime(2022, 1, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4380), "married", 5, new DateTime(2021, 2, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4381), 399 },
                    { 12, 71.939999999999998, new DateTime(2022, 5, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4377), "contact", 5, new DateTime(2020, 10, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4378), 262 },
                    { 11, 49.689999999999998, new DateTime(2022, 12, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4369), "testimony", 4, new DateTime(2020, 3, 23, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4370), 332 },
                    { 10, 22.010000000000002, new DateTime(2022, 6, 3, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4363), "contact", 3, new DateTime(2020, 10, 3, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4364), 401 },
                    { 9, 81.959999999999994, new DateTime(2022, 6, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4359), "production", 3, new DateTime(2020, 9, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4360), 339 },
                    { 8, 9.8699999999999992, new DateTime(2022, 10, 12, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4354), "dress", 3, new DateTime(2020, 5, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4355), 313 },
                    { 7, 54.289999999999999, new DateTime(2021, 9, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4351), "production", 3, new DateTime(2021, 6, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4352), 226 }
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "Cost", "ExpirationDate", "Manufacturer", "ProductId", "PurchasedDate", "Quantities" },
                values: new object[,]
                {
                    { 6, 75.769999999999996, new DateTime(2022, 10, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4344), "testimony", 2, new DateTime(2020, 5, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4345), 142 },
                    { 5, 35.329999999999998, new DateTime(2022, 12, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4336), "during", 2, new DateTime(2020, 3, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4337), 160 },
                    { 4, 68.390000000000001, new DateTime(2022, 6, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4333), "boom", 2, new DateTime(2020, 9, 20, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4334), 464 },
                    { 3, 93.980000000000004, new DateTime(2022, 10, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4308), "adapt", 1, new DateTime(2020, 5, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4309), 224 },
                    { 2, 66.709999999999994, new DateTime(2023, 2, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4303), "adapt", 1, new DateTime(2020, 1, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4306), 105 },
                    { 29, 42.880000000000003, new DateTime(2022, 11, 3, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4443), "production", 11, new DateTime(2020, 5, 3, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4444), 232 },
                    { 121, 29.670000000000002, new DateTime(2022, 9, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4860), "sigh", 49, new DateTime(2020, 6, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4861), 332 },
                    { 30, 67.560000000000002, new DateTime(2021, 9, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4449), "ground", 12, new DateTime(2021, 6, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4450), 71 },
                    { 32, 37.539999999999999, new DateTime(2023, 6, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4507), "taxpayer", 16, new DateTime(2019, 9, 12, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4508), 355 },
                    { 59, 30.899999999999999, new DateTime(2023, 1, 7, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4615), "comparison", 29, new DateTime(2020, 2, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4615), 379 },
                    { 58, 84.209999999999994, new DateTime(2023, 6, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4612), "precisely", 29, new DateTime(2019, 9, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4613), 161 },
                    { 57, 27.989999999999998, new DateTime(2022, 3, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4610), "exactly", 29, new DateTime(2020, 12, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4611), 196 },
                    { 56, 36.439999999999998, new DateTime(2023, 3, 12, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4604), "mark", 28, new DateTime(2019, 12, 26, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4605), 432 },
                    { 55, 50.25, new DateTime(2023, 1, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4601), "egg", 28, new DateTime(2020, 2, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4602), 178 },
                    { 54, 10.41, new DateTime(2022, 1, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4598), "exactly", 28, new DateTime(2021, 3, 5, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4599), 88 },
                    { 53, 27.68, new DateTime(2023, 3, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4596), "circumstance", 28, new DateTime(2019, 12, 21, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4597), 17 },
                    { 52, 1.0, new DateTime(2021, 9, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4593), "system", 28, new DateTime(2021, 6, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4594), 68 },
                    { 51, 91.439999999999998, new DateTime(2021, 12, 5, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4580), "expression", 24, new DateTime(2021, 4, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4581), 62 },
                    { 50, 99.780000000000001, new DateTime(2022, 6, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4578), "ground", 24, new DateTime(2020, 9, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4579), 46 },
                    { 49, 27.420000000000002, new DateTime(2023, 4, 3, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4575), "boom", 24, new DateTime(2019, 12, 4, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4576), 474 },
                    { 48, 19.440000000000001, new DateTime(2022, 7, 27, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4573), "taxpayer", 24, new DateTime(2020, 8, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4574), 192 },
                    { 47, 46.710000000000001, new DateTime(2023, 4, 23, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4567), "cover", 23, new DateTime(2019, 11, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4568), 367 },
                    { 46, 10.859999999999999, new DateTime(2021, 10, 8, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4565), "during", 23, new DateTime(2021, 5, 29, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4566), 216 },
                    { 45, 81.569999999999993, new DateTime(2023, 5, 17, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4559), "detect", 22, new DateTime(2019, 10, 21, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4560), 10 },
                    { 44, 66.819999999999993, new DateTime(2023, 6, 6, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4554), "mere", 21, new DateTime(2019, 10, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4555), 454 },
                    { 43, 71.060000000000002, new DateTime(2022, 11, 23, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4551), "cast", 21, new DateTime(2020, 4, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4552), 168 },
                    { 42, 7.8899999999999997, new DateTime(2022, 4, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4549), "comparison", 21, new DateTime(2020, 11, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4550), 135 },
                    { 41, 17.059999999999999, new DateTime(2022, 8, 15, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4546), "adapt", 21, new DateTime(2020, 7, 22, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4547), 223 },
                    { 40, 43.200000000000003, new DateTime(2022, 7, 9, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4544), "during", 21, new DateTime(2020, 8, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4545), 140 },
                    { 39, 94.950000000000003, new DateTime(2022, 1, 20, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4539), "impress", 20, new DateTime(2021, 2, 14, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4540), 475 },
                    { 38, 61.350000000000001, new DateTime(2023, 5, 28, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4537), "software", 20, new DateTime(2019, 10, 10, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4538), 132 },
                    { 37, 83.810000000000002, new DateTime(2023, 4, 18, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4534), "mere", 20, new DateTime(2019, 11, 19, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4535), 215 },
                    { 36, 7.1799999999999997, new DateTime(2023, 7, 22, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4528), "mere", 19, new DateTime(2019, 8, 16, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4529), 349 },
                    { 35, 12.1, new DateTime(2022, 10, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4526), "sanction", 19, new DateTime(2020, 5, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4527), 395 },
                    { 34, 27.399999999999999, new DateTime(2022, 4, 6, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4523), "taxpayer", 19, new DateTime(2020, 11, 30, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4524), 384 },
                    { 33, 39.579999999999998, new DateTime(2023, 6, 24, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4510), "board", 16, new DateTime(2019, 9, 13, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4511), 152 },
                    { 31, 39.130000000000003, new DateTime(2022, 3, 5, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4498), "contact", 14, new DateTime(2021, 1, 1, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4499), 497 },
                    { 122, 86.359999999999999, new DateTime(2021, 10, 12, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4862), "circle", 49, new DateTime(2021, 5, 25, 16, 10, 53, 372, DateTimeKind.Utc).AddTicks(4863), 271 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batches_ProductId",
                table: "Batches",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
