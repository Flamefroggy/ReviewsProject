using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewsData.Migrations
{
    /// <inheritdoc />
    public partial class changebooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Title", "Rating" },
                values: new object[,]
                {
                    { 1, "хохол", "Мойдодыр", 7m },
                    { 2, "АБВГД", "Азбука", 5m },
                    { 3, "Аннотация – краткое описание книги, которое дает читателю представление о произведении, рассказывает завязку сюжета или обозначает общую тему книги. Обычно аннотация публикуется на обороте книги.", "Дихотомия добра и зла", 2m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
