using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karte_Filmovi_filmId",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "IDSedista",
                table: "Karte");

            migrationBuilder.RenameColumn(
                name: "filmId",
                table: "Karte",
                newName: "sedisteId");

            migrationBuilder.RenameIndex(
                name: "IX_Karte_filmId",
                table: "Karte",
                newName: "IX_Karte_sedisteId");

            migrationBuilder.AddColumn<int>(
                name: "projekcijaId",
                table: "Karte",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Karte_projekcijaId",
                table: "Karte",
                column: "projekcijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Karte_Projkecije_projekcijaId",
                table: "Karte",
                column: "projekcijaId",
                principalTable: "Projkecije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Karte_Sedista_sedisteId",
                table: "Karte",
                column: "sedisteId",
                principalTable: "Sedista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karte_Projkecije_projekcijaId",
                table: "Karte");

            migrationBuilder.DropForeignKey(
                name: "FK_Karte_Sedista_sedisteId",
                table: "Karte");

            migrationBuilder.DropIndex(
                name: "IX_Karte_projekcijaId",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "projekcijaId",
                table: "Karte");

            migrationBuilder.RenameColumn(
                name: "sedisteId",
                table: "Karte",
                newName: "filmId");

            migrationBuilder.RenameIndex(
                name: "IX_Karte_sedisteId",
                table: "Karte",
                newName: "IX_Karte_filmId");

            migrationBuilder.AddColumn<int>(
                name: "IDSedista",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Karte_Filmovi_filmId",
                table: "Karte",
                column: "filmId",
                principalTable: "Filmovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
