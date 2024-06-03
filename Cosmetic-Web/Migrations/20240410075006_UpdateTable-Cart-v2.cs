using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cosmetic_Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableCartv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CartDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_UserId",
                table: "CartDetails",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetails_Users_UserId",
                table: "CartDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetails_Users_UserId",
                table: "CartDetails");

            migrationBuilder.DropIndex(
                name: "IX_CartDetails_UserId",
                table: "CartDetails");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CartDetails");
        }
    }
}
