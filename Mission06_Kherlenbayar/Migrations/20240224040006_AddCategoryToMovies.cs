using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Kherlenbayar.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Movies",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Movies");
        }
    }
}
