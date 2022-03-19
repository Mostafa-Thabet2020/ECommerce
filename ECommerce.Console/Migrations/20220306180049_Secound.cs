using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Migrations
{
    public partial class Secound : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_users_UserID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Order_orderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_productId",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Profit",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "orderDetails");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "orders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_productId",
                table: "orderDetails",
                newName: "IX_orderDetails_productId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_orderId",
                table: "orderDetails",
                newName: "IX_orderDetails_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserID",
                table: "orders",
                newName: "IX_orders_UserID");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedTime",
                table: "orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsShipped",
                table: "orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_orders_orderId",
                table: "orderDetails",
                column: "orderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_products_productId",
                table: "orderDetails",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_users_UserID",
                table: "orders",
                column: "UserID",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_orders_orderId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_products_productId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_users_UserID",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "DeletedTime",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "IsShipped",
                table: "orders");

            migrationBuilder.RenameTable(
                name: "orderDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_productId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_productId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_orderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_orderId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_UserID",
                table: "Order",
                newName: "IX_Order_UserID");

            migrationBuilder.AddColumn<double>(
                name: "Profit",
                table: "products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_users_UserID",
                table: "Order",
                column: "UserID",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Order_orderId",
                table: "OrderDetails",
                column: "orderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_productId",
                table: "OrderDetails",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
