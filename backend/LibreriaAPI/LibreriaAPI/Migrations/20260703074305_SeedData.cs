using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibreriaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Libreria__Catego__3B75D760",
                table: "Libreria");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Libreria__3214EC07D9A1B0C3",
                table: "Libreria");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Categori__3214EC07A0D9B1F3",
                table: "Categoria");

            migrationBuilder.AlterColumn<string>(
                name: "NombreLibro",
                table: "Libreria",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Categoria",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Libreria",
                table: "Libreria",
                column: "IdLibro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Historias de amor y relaciones.", "Romance" },
                    { 2, "Mundos fantásticos, magia y aventuras.", "Fantasía" },
                    { 3, "Obras reconocidas de la literatura universal.", "Literatura Clásica" }
                });

            migrationBuilder.InsertData(
                table: "Libreria",
                columns: new[] { "IdLibro", "Autor", "CategoriaId", "Descripcion", "ImagURL", "NombreLibro", "Precio" },
                values: new object[,]
                {
                    { 1, "Jojo Moyes", 1, "Una emotiva historia de amor.", "/imagenes/yo-antes-de-ti.jpg", "Yo Antes de Ti", 429.00m },
                    { 2, "John Green", 1, "Una historia de amor inolvidable.", "/imagenes/bajo-la-misma-estrella.jpg", "Bajo la Misma Estrella", 399.00m },
                    { 3, "Nicholas Sparks", 1, "Un romance que desafía el tiempo.", "/imagenes/el-diario-de-noah.jpg", "El Diario de Noah", 450.00m },
                    { 4, "J. R. R. Tolkien", 2, "La aventura de Bilbo Bolsón.", "/imagenes/el-hobbit.jpg", "El Hobbit", 390.00m },
                    { 5, "J. K. Rowling", 2, "El inicio de la saga de Harry Potter.", "/imagenes/harry-potter-1.jpg", "Harry Potter y la Piedra Filosofal", 450.00m },
                    { 6, "C. S. Lewis", 2, "Viaje al mágico mundo de Narnia.", "/imagenes/narnia.jpg", "Las Crónicas de Narnia", 480.00m },
                    { 7, "Miguel de Cervantes", 3, "Obra maestra de Miguel de Cervantes.", "/imagenes/don-quijote.jpg", "Don Quijote de la Mancha", 350.00m },
                    { 8, "Jane Austen", 3, "Clásico de Jane Austen.", "/imagenes/orgullo-prejuicio.jpg", "Orgullo y Prejuicio", 320.00m },
                    { 9, "Herman Melville", 3, "La búsqueda de la legendaria ballena blanca.", "/imagenes/moby-dick.jpg", "Moby Dick", 410.00m },
                    { 10, "Gabriel García Márquez", 3, "Obra cumbre del realismo mágico.", "/imagenes/cien-anos-soledad.jpg", "Cien Años de Soledad", 530.00m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Libreria_Categoria_CategoriaId",
                table: "Libreria",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libreria_Categoria_CategoriaId",
                table: "Libreria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Libreria",
                table: "Libreria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Libreria",
                keyColumn: "IdLibro",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "NombreLibro",
                table: "Libreria",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Categoria",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Libreria__3214EC07D9A1B0C3",
                table: "Libreria",
                column: "IdLibro");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Categori__3214EC07A0D9B1F3",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Libreria__Catego__3B75D760",
                table: "Libreria",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
