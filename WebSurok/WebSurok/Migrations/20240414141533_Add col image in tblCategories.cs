using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSurok.Migrations
{
    /// <inheritdoc />
    public partial class AddcolimageintblCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "tblCategories",
                type: "TEXT",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "tblCategories");
        }
    }
}
