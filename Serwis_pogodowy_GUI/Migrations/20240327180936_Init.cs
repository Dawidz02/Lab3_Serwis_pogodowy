using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Serwis_pogodowy_GUI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PogodaInicjalizuj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    miasto = table.Column<string>(type: "TEXT", nullable: false),
                    temperatura = table.Column<double>(type: "REAL", nullable: false),
                    cisnienie = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PogodaInicjalizuj", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PogodaInicjalizuj",
                columns: new[] { "Id", "cisnienie", "miasto", "temperatura" },
                values: new object[,]
                {
                    { 1, 959.0, "Warszawa", 20.0 },
                    { 2, 965.0, "Gdańsk", 18.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PogodaInicjalizuj");
        }
    }
}
