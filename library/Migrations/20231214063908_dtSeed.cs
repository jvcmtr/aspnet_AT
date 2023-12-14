using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library.Migrations
{
    public partial class dtSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Terror" },
                    { 2, "Ação" },
                    { 3, "Aventura" },
                    { 4, "Suspense" },
                    { 5, "Romance" },
                    { 6, "Erotico" },
                    { 7, "Misterio" },
                    { 8, "Cronica" },
                    { 9, "Historico" },
                    { 10, "Filosofia" },
                    { 11, "Quadrinhos" },
                    { 12, "Culinaria" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
