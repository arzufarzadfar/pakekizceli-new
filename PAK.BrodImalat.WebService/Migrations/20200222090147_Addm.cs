using Microsoft.EntityFrameworkCore.Migrations;

namespace PAK.BrodImalat.WebService.Migrations
{
    public partial class Addm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "status");

            migrationBuilder.AddColumn<int>(
                name: "StatuCode",
                table: "status",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StatuName",
                table: "status",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Statu",
                table: "orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "statusId",
                table: "orders",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TokenResource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expiration = table.Column<long>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenResource", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_statusId",
                table: "orders",
                column: "statusId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_status_statusId",
                table: "orders",
                column: "statusId",
                principalTable: "status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_status_statusId",
                table: "orders");

            migrationBuilder.DropTable(
                name: "TokenResource");

            migrationBuilder.DropIndex(
                name: "IX_orders_statusId",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "StatuCode",
                table: "status");

            migrationBuilder.DropColumn(
                name: "StatuName",
                table: "status");

            migrationBuilder.DropColumn(
                name: "statusId",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "status",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Statu",
                table: "orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
