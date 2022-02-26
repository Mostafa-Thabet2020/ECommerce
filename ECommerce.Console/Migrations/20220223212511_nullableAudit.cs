using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations
{
    public partial class nullableAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                table: "users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "mobiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                table: "mobiles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "governrotes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                table: "governrotes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "cities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                table: "cities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedBy",
                table: "addresses",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "users");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "mobiles");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "mobiles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "governrotes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "governrotes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "cities");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "cities");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "addresses");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "addresses");
        }
    }
}
