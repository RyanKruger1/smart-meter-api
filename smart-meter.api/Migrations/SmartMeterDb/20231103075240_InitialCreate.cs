using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smart_meter.api.Migrations.SmartMeterDb
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "meters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "meters",
                columns: new[] { "Id", "location", "name", "zipCode" },
                values: new object[] { new Guid("6cb3bcad-d8cc-445c-a969-1bf8c1f8e7e9"), "here", "everywhere", "there" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "meters");
        }
    }
}
