using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDKorisnika",
                table: "Karte");

            migrationBuilder.AddColumn<int>(
                name: "korisnikId",
                table: "Karte",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Karte_korisnikId",
                table: "Karte",
                column: "korisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Karte_Korisnici_korisnikId",
                table: "Karte",
                column: "korisnikId",
                principalTable: "Korisnici",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karte_Korisnici_korisnikId",
                table: "Karte");

            migrationBuilder.DropIndex(
                name: "IX_Karte_korisnikId",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "korisnikId",
                table: "Karte");

            migrationBuilder.AddColumn<int>(
                name: "IDKorisnika",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
