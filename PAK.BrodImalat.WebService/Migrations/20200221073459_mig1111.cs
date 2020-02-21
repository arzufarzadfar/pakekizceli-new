using Microsoft.EntityFrameworkCore.Migrations;

namespace PAK.BrodImalat.WebService.Migrations
{
    public partial class mig1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "firsName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firsName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "AspNetUsers");
        }
    }
}
