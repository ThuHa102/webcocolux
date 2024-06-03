using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cosmetic_Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableUpdateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "Images");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Images",
                table: "Products",
                newName: "Image");
        }
    }
}
