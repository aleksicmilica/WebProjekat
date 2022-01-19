using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    zanr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    trajanje = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Povlascen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrRedova = table.Column<int>(type: "int", nullable: false),
                    BrSedistaPoRedu = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrReda = table.Column<int>(type: "int", nullable: false),
                    BrSedistaURedu = table.Column<int>(type: "int", nullable: false),
                    Zauzet = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projkecije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filmId = table.Column<int>(type: "int", nullable: true),
                    vreme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salaId = table.Column<int>(type: "int", nullable: true),
                    RepertoarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projkecije", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projkecije_Filmovi_filmId",
                        column: x => x.filmId,
                        principalTable: "Filmovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projkecije_Repertoari_RepertoarId",
                        column: x => x.RepertoarId,
                        principalTable: "Repertoari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projkecije_Sale_salaId",
                        column: x => x.salaId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Karte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projekcijeId = table.Column<int>(type: "int", nullable: true),
                    brSedistaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Karte_Projkecije_projekcijeId",
                        column: x => x.projekcijeId,
                        principalTable: "Projkecije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Karte_Sedista_brSedistaId",
                        column: x => x.brSedistaId,
                        principalTable: "Sedista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Karte_brSedistaId",
                table: "Karte",
                column: "brSedistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Karte_projekcijeId",
                table: "Karte",
                column: "projekcijeId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karte");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Projkecije");

            migrationBuilder.DropTable(
                name: "Sedista");

            migrationBuilder.DropTable(
                name: "Filmovi");

            migrationBuilder.DropTable(
                name: "Repertoari");

            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
