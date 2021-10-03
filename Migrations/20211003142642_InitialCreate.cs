using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StashMash.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fibers",
                columns: table => new
                {
                    FiberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fibers", x => x.FiberId);
                });

            migrationBuilder.CreateTable(
                name: "FiberWeights",
                columns: table => new
                {
                    FiberWeightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FiberWeights", x => x.FiberWeightId);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "Yarn",
                columns: table => new
                {
                    YarnId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    FiberId = table.Column<int>(nullable: false),
                    FiberWeightId = table.Column<int>(nullable: false),
                    SkeinYardage = table.Column<int>(nullable: false),
                    SkeinWeight = table.Column<double>(nullable: false),
                    MeasurementUnit = table.Column<string>(nullable: true),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yarn", x => x.YarnId);
                    table.ForeignKey(
                        name: "FK_Yarn_Fibers_FiberId",
                        column: x => x.FiberId,
                        principalTable: "Fibers",
                        principalColumn: "FiberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yarn_FiberWeights_FiberWeightId",
                        column: x => x.FiberWeightId,
                        principalTable: "FiberWeights",
                        principalColumn: "FiberWeightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yarn_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YarnDetails",
                columns: table => new
                {
                    YarnDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YarnId = table.Column<int>(nullable: false),
                    YarnColor = table.Column<string>(nullable: true),
                    YarnColorCode = table.Column<string>(nullable: true),
                    YarnColorLot = table.Column<string>(nullable: true),
                    QuantityOfSkeins = table.Column<double>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YarnDetails", x => x.YarnDetailId);
                    table.ForeignKey(
                        name: "FK_YarnDetails_Yarn_YarnId",
                        column: x => x.YarnId,
                        principalTable: "Yarn",
                        principalColumn: "YarnId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FiberWeights",
                columns: new[] { "FiberWeightId", "Name", "Symbol" },
                values: new object[,]
                {
                    { 8, "Jumbo", 7 },
                    { 7, "Super Bulky", 6 },
                    { 6, "Bulky", 5 },
                    { 5, "Worsted", 4 },
                    { 4, "DK", 3 },
                    { 3, "Fine", 2 },
                    { 2, "Fingering", 1 },
                    { 1, "Lace", 0 }
                });

            migrationBuilder.InsertData(
                table: "Fibers",
                columns: new[] { "FiberId", "Name" },
                values: new object[,]
                {
                    { 1, "Wool" },
                    { 20, "Eyelash" },
                    { 19, "Kid Mohair" },
                    { 18, "Mohair" },
                    { 17, "Polyester" },
                    { 15, "Faux Fur" },
                    { 16, "Railroad Ribbon" },
                    { 13, "Boucle" },
                    { 12, "Angora" },
                    { 11, "Acrylic" },
                    { 10, "Bamboo" },
                    { 9, "Hemp" },
                    { 8, "Silk" },
                    { 7, "Mercerized Cotton" },
                    { 6, "Cotton" },
                    { 5, "Organic Wool" },
                    { 4, "Merino Wool" },
                    { 3, "Alpaca" },
                    { 2, "Cashmere" },
                    { 14, "Chenille" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "Name", "Url" },
                values: new object[,]
                {
                    { 2, "Rowan", "https://knitrowan.com" },
                    { 1, "Nako", "http://www.nako.com/" },
                    { 3, "Shibui", "https://shibuiknits.com" }
                });

            migrationBuilder.InsertData(
                table: "Yarn",
                columns: new[] { "YarnId", "DateUpdated", "FiberId", "FiberWeightId", "ManufacturerId", "MeasurementUnit", "Name", "SkeinWeight", "SkeinYardage" },
                values: new object[] { 1, new DateTime(2021, 10, 3, 6, 26, 42, 60, DateTimeKind.Local).AddTicks(7053), 3, 3, 1, null, "Arya Ebruli", 100.0, 550 });

            migrationBuilder.InsertData(
                table: "Yarn",
                columns: new[] { "YarnId", "DateUpdated", "FiberId", "FiberWeightId", "ManufacturerId", "MeasurementUnit", "Name", "SkeinWeight", "SkeinYardage" },
                values: new object[] { 2, new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(4451), 4, 6, 2, null, "Brushed Fleece", 50.0, 115 });

            migrationBuilder.InsertData(
                table: "Yarn",
                columns: new[] { "YarnId", "DateUpdated", "FiberId", "FiberWeightId", "ManufacturerId", "MeasurementUnit", "Name", "SkeinWeight", "SkeinYardage" },
                values: new object[] { 3, new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(4509), 19, 1, 3, null, "Silk Cloud", 25.0, 330 });

            migrationBuilder.InsertData(
                table: "YarnDetails",
                columns: new[] { "YarnDetailId", "DateUpdated", "QuantityOfSkeins", "YarnColor", "YarnColorCode", "YarnColorLot", "YarnId" },
                values: new object[] { 1, new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(5115), 4.0, "Gray", "86398", "76643", 1 });

            migrationBuilder.InsertData(
                table: "YarnDetails",
                columns: new[] { "YarnDetailId", "DateUpdated", "QuantityOfSkeins", "YarnColor", "YarnColorCode", "YarnColorLot", "YarnId" },
                values: new object[] { 2, new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(6205), 1.0, "Green", "00236", "3848", 2 });

            migrationBuilder.InsertData(
                table: "YarnDetails",
                columns: new[] { "YarnDetailId", "DateUpdated", "QuantityOfSkeins", "YarnColor", "YarnColorCode", "YarnColorLot", "YarnId" },
                values: new object[] { 3, new DateTime(2021, 10, 3, 6, 26, 42, 61, DateTimeKind.Local).AddTicks(6246), 7.0, "Silver", "2022", "1256", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Yarn_FiberId",
                table: "Yarn",
                column: "FiberId");

            migrationBuilder.CreateIndex(
                name: "IX_Yarn_FiberWeightId",
                table: "Yarn",
                column: "FiberWeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Yarn_ManufacturerId",
                table: "Yarn",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_YarnDetails_YarnId",
                table: "YarnDetails",
                column: "YarnId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YarnDetails");

            migrationBuilder.DropTable(
                name: "Yarn");

            migrationBuilder.DropTable(
                name: "Fibers");

            migrationBuilder.DropTable(
                name: "FiberWeights");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
