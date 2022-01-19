using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdSale",
                table: "Sedista");

            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Karte");

            migrationBuilder.AddColumn<int>(
                name: "salaId",
                table: "Sedista",
                type: "int",
                nullable: true);

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
                name: "Cena",
                table: "Filmovi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "bioskopId",
                table: "Filmovi",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bioskopi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bioskopi", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sedista_salaId",
                table: "Sedista",
                column: "salaId");

            migrationBuilder.CreateIndex(
                name: "IX_Projkecije_filmId",
                table: "Projkecije",
                column: "filmId");

            migrationBuilder.CreateIndex(
                name: "IX_Projkecije_salaId",
                table: "Projkecije",
                column: "salaId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmovi_bioskopId",
                table: "Filmovi",
                column: "bioskopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmovi_Bioskopi_bioskopId",
                table: "Filmovi",
                column: "bioskopId",
                principalTable: "Bioskopi",
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
                name: "FK_Projkecije_Sale_salaId",
                table: "Projkecije",
                column: "salaId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sedista_Sale_salaId",
                table: "Sedista",
                column: "salaId",
                principalTable: "Sale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmovi_Bioskopi_bioskopId",
                table: "Filmovi");

            migrationBuilder.DropForeignKey(
                name: "FK_Projkecije_Filmovi_filmId",
                table: "Projkecije");

            migrationBuilder.DropForeignKey(
                name: "FK_Projkecije_Sale_salaId",
                table: "Projkecije");

            migrationBuilder.DropForeignKey(
                name: "FK_Sedista_Sale_salaId",
                table: "Sedista");

            migrationBuilder.DropTable(
                name: "Bioskopi");

            migrationBuilder.DropIndex(
                name: "IX_Sedista_salaId",
                table: "Sedista");

            migrationBuilder.DropIndex(
                name: "IX_Projkecije_filmId",
                table: "Projkecije");

            migrationBuilder.DropIndex(
                name: "IX_Projkecije_salaId",
                table: "Projkecije");

            migrationBuilder.DropIndex(
                name: "IX_Filmovi_bioskopId",
                table: "Filmovi");

            migrationBuilder.DropColumn(
                name: "salaId",
                table: "Sedista");

            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Filmovi");

            migrationBuilder.DropColumn(
                name: "bioskopId",
                table: "Filmovi");

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

            migrationBuilder.AddColumn<int>(
                name: "Cena",
                table: "Karte",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
