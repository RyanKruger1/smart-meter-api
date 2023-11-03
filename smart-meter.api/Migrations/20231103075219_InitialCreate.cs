using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace smart_meter.api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "readings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    smartMeterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    readingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    voltage = table.Column<double>(type: "float", nullable: false),
                    current = table.Column<double>(type: "float", nullable: false),
                    power = table.Column<double>(type: "float", nullable: false),
                    powerFactor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_readings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "readings",
                columns: new[] { "Id", "current", "power", "powerFactor", "readingTime", "smartMeterId", "voltage" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, 0.0, new DateTime(2023, 11, 3, 9, 52, 18, 924, DateTimeKind.Local).AddTicks(4301), new Guid("00000000-0000-0000-0000-000000000000"), 0.0 },
                    { 2, 1.0, 1.0, 1.0, new DateTime(2023, 11, 3, 9, 52, 18, 924, DateTimeKind.Local).AddTicks(4341), new Guid("00000000-0000-0000-0000-000000000000"), 1.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "readings");
        }
    }
}
