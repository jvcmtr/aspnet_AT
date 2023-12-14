using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library.Migrations
{
    public partial class dt_seed_livros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "Created", "DataDePublicacao", "GeneroId", "ISBN", "Name", "Sinopse" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "11-11-11-11", "O Hobbit", null });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "Created", "DataDePublicacao", "GeneroId", "ISBN", "Name", "Sinopse" },
                values: new object[] { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Melhor quadrinho já publicado", "One Piece", null });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "Created", "DataDePublicacao", "GeneroId", "ISBN", "Name", "Sinopse" },
                values: new object[] { 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1548, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Recomendo Fortemente", "Discurso sobre a servidão voluntária", "é uma crítica à legitimidade dos governantes, chamados por ele de “tiranos”. La Boétie explica de que maneira os povos podem se submeter voluntariamente ao governo de um só homem... [Fonte Wikipedia]" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
