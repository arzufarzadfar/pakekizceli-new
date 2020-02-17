using Microsoft.EntityFrameworkCore.Migrations;

namespace PAK.BrodImalat.WebService.Migrations
{
    public partial class adq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "status",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
