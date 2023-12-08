using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GdMAPI.Migrations
{
    /// <inheritdoc />
    public partial class InnitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_MATERIAL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MATERIAL", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_MATERIAL",
                columns: new[] { "Id", "Cor", "Marca", "Nome", "Quantidade", "Tipo" },
                values: new object[,]
                {
                    { 1, "Preto", "FaberCastell", "Lápis", 1, 1 },
                    { 2, "Azul", "BIC", "Caneta", 1, 2 },
                    { 3, "Branco", "Mercur", "Borracha", 1, 3 },
                    { 4, "Transparente", "Cis", "Apontador", 1, 4 },
                    { 5, "Vermelho", "Spriral", "Caderno", 1, 7 },
                    { 6, "Cinza", "SAE", "Livro", 1, 8 },
                    { 7, "Azul", "Kipling", "Mochila", 1, 6 },
                    { 8, "Cinza", "Genérica", "Estojo", 1, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_MATERIAL");
        }
    }
}
