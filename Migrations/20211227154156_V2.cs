using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karte_Projkecije_projekcijeId",
                table: "Karte");

            migrationBuilder.DropForeignKey(
                name: "FK_Karte_Sedista_brSedistaId",
                table: "Karte");

            migrationBuilder.DropForeignKey(
                name: "FK_Projkecije_Filmovi_filmId",
                table: "Projkecije");

            migrationBuilder.DropForeignKey(
                name: "FK_Projkecije_Repertoari_RepertoarId",
                table: "Projkecije");

            migrationBuilder.DropForeignKey(
                name: "FK_Projkecije_Sale_salaId",
                table: "Projkecije");

            migrationBuilder.DropTable(
                name: "Repertoari");

            migrationBuilder.DropIndex(
                name: "IX_Projkecije_filmId",
                table: "Projkecije");

            migrationBuilder.DropIndex(
                name: "IX_Projkecije_RepertoarId",
                table: "Projkecije");

            migrationBuilder.DropIndex(
                name: "IX_Projkecije_salaId",
                table: "Projkecije");

            migrationBuilder.DropIndex(
                name: "IX_Karte_brSedistaId",
                table: "Karte");

            migrationBuilder.DropIndex(
                name: "IX_Karte_projekcijeId",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "Zauzet",
                table: "Sedista");

            migrationBuilder.DropColumn(
                name: "RepertoarId",
                table: "Projkecije");

            migrationBuilder.DropColumn(
                name: "Povlascen",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "brSedistaId",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "projekcijeId",
                table: "Karte");

            migrationBuilder.AddColumn<int>(
                name: "IdSale",
                table: "Sedista",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "salaId",
                table: "Projkecije",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "filmId",
                table: "Projkecije",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisnici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisnici",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumRodj",
                table: "Korisnici",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Cena",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDKorisnika",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDSedista",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IDprojekcije",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "datumKraja",
                table: "Filmovi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "datumPocetka",
                table: "Filmovi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdSale",
                table: "Sedista");

            migrationBuilder.DropColumn(
                name: "DatumRodj",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "IDKorisnika",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "IDSedista",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "IDprojekcije",
                table: "Karte");

            migrationBuilder.DropColumn(
                name: "datumKraja",
                table: "Filmovi");

            migrationBuilder.DropColumn(
                name: "datumPocetka",
                table: "Filmovi");

            migrationBuilder.AddColumn<bool>(
                name: "Zauzet",
                table: "Sedista",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "salaId",
                table: "Projkecije",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "filmId",
                table: "Projkecije",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RepertoarId",
                table: "Projkecije",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisnici",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisnici",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Povlascen",
                table: "Korisnici",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "brSedistaId",
                table: "Karte",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "projekcijeId",
                table: "Karte",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Repertoari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repertoari", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projkecije_filmId",
                table: "Projkecije",
                column: "filmId");

            migrationBuilder.CreateIndex(
                name: "IX_Projkecije_RepertoarId",
                table: "Projkecije",
                column: "RepertoarId");

            migrationBuilder.CreateIndex(
                name: "IX_Projkecije_salaId",
                table: "Projkecije",
                column: "salaId");

            migrationBuilder.CreateIndex(
                name: "IX_Karte_brSedistaId",
                table: "Karte",
                column: "brSedistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Karte_projekcijeId",
                table: "Karte",
                column: "projekcijeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Karte_Projkecije_projekcijeId",
                table: "Karte",
                column: "projekcijeId",
                principalTable: "Projkecije",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Karte_Sedista_brSedistaId",
                table: "Karte",
                column: "brSedistaId",
                principalTable: "Sedista",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projkecije_Filmovi_filmId",
                table: "Projkecije",
                column: "filmId",
                principalTable: "Filmovi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projkecije_Repertoari_RepertoarId",
                table: "Projkecije",
                column: "RepertoarId",
                principalTable: "Repertoari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projkecije_Sale_salaId",
                table: "Projkecije",
                column: "salaId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
