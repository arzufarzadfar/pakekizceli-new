using Microsoft.EntityFrameworkCore.Migrations;

namespace PAK.BrodImalat.WebService.Migrations
{
    public partial class hh3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GropId",
                table: "Student",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "grop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grop", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_GropId",
                table: "Student",
                column: "GropId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_grop_GropId",
                table: "Student",
                column: "GropId",
                principalTable: "grop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_grop_GropId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "grop");

            migrationBuilder.DropIndex(
                name: "IX_Student_GropId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GropId",
                table: "Student");
        }
    }
}
