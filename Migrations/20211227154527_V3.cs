using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDprojekcije",
                table: "Karte");

            migrationBuilder.AddColumn<int>(
                name: "filmId",
                table: "Karte",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Karte_filmId",
                table: "Karte",
                column: "filmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Karte_Filmovi_filmId",
                table: "Karte",
                column: "filmId",
                principalTable: "Filmovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karte_Filmovi_filmId",
                table: "Karte");

            migrationBuilder.DropIndex(
                name: "IX_Karte_filmId",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "filmId",
                table: "Karte");

            migrationBuilder.AddColumn<int>(
                name: "IDprojekcije",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
