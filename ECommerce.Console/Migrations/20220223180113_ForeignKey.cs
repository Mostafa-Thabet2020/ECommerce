using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_cities_cityId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_addresses_users_userId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_cities_governrotes_governroteId",
                table: "cities");

            migrationBuilder.DropForeignKey(
                name: "FK_mobiles_users_userId",
                table: "mobiles");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "mobiles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_mobiles_userId",
                table: "mobiles",
                newName: "IX_mobiles_UserId");

            migrationBuilder.RenameColumn(
                name: "governroteId",
                table: "cities",
                newName: "GovernroteId");

            migrationBuilder.RenameIndex(
                name: "IX_cities_governroteId",
                table: "cities",
                newName: "IX_cities_GovernroteId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "addresses",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "cityId",
                table: "addresses",
                newName: "CitiyId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_userId",
                table: "addresses",
                newName: "IX_addresses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_cityId",
                table: "addresses",
                newName: "IX_addresses_CitiyId");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_cities_CitiyId",
                table: "addresses",
                column: "CitiyId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_users_UserId",
                table: "addresses",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cities_governrotes_GovernroteId",
                table: "cities",
                column: "GovernroteId",
                principalTable: "governrotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mobiles_users_UserId",
                table: "mobiles",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_cities_CitiyId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_addresses_users_UserId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_cities_governrotes_GovernroteId",
                table: "cities");

            migrationBuilder.DropForeignKey(
                name: "FK_mobiles_users_UserId",
                table: "mobiles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "mobiles",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_mobiles_UserId",
                table: "mobiles",
                newName: "IX_mobiles_userId");

            migrationBuilder.RenameColumn(
                name: "GovernroteId",
                table: "cities",
                newName: "governroteId");

            migrationBuilder.RenameIndex(
                name: "IX_cities_GovernroteId",
                table: "cities",
                newName: "IX_cities_governroteId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "addresses",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "CitiyId",
                table: "addresses",
                newName: "cityId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_UserId",
                table: "addresses",
                newName: "IX_addresses_userId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_CitiyId",
                table: "addresses",
                newName: "IX_addresses_cityId");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_cities_cityId",
                table: "addresses",
                column: "cityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_users_userId",
                table: "addresses",
                column: "userId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cities_governrotes_governroteId",
                table: "cities",
                column: "governroteId",
                principalTable: "governrotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_mobiles_users_userId",
                table: "mobiles",
                column: "userId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
