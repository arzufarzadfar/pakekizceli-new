using Microsoft.EntityFrameworkCore.Migrations;

namespace PAK.BrodImalat.WebService.Migrations
{
    public partial class c1s2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_status_orders_OrderId",
                table: "status");

            migrationBuilder.DropIndex(
                name: "IX_status_OrderId",
                table: "status");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "status");

            migrationBuilder.AddColumn<int>(
                name: "Statu",
                table: "orders",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Statu",
                table: "orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "status",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_status_OrderId",
                table: "status",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_status_orders_OrderId",
                table: "status",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
