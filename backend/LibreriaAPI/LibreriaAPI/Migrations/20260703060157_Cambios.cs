using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibreriaAPI.Migrations
{
    /// <inheritdoc />
    public partial class Cambios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libreria_Categoria_CategoriaId1",
                table: "Libreria");

            migrationBuilder.DropIndex(
                name: "IX_Libreria_CategoriaId1",
                table: "Libreria");

            migrationBuilder.DropColumn(
                name: "CategoriaId1",
                table: "Libreria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaId1",
                table: "Libreria",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Libreria_CategoriaId1",
                table: "Libreria",
                column: "CategoriaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Libreria_Categoria_CategoriaId1",
                table: "Libreria",
                column: "CategoriaId1",
                principalTable: "Categoria",
                principalColumn: "Id");
        }
    }
}
