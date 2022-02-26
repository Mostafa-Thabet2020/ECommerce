using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "users",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "mobiles",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "governrotes",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "cities",
                newName: "LastModifiedDate");

            migrationBuilder.RenameColumn(
                name: "ModifiedDate",
                table: "addresses",
                newName: "LastModifiedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "users",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "mobiles",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "governrotes",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "cities",
                newName: "ModifiedDate");

            migrationBuilder.RenameColumn(
                name: "LastModifiedDate",
                table: "addresses",
                newName: "ModifiedDate");
        }
    }
}
