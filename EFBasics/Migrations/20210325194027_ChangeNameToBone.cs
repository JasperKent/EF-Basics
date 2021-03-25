using Microsoft.EntityFrameworkCore.Migrations;

namespace EFBasics.Migrations
{
    public partial class ChangeNameToBone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FavouriteBone",
                table: "Pets",
                newName: "Bone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bone",
                table: "Pets",
                newName: "FavouriteBone");
        }
    }
}
