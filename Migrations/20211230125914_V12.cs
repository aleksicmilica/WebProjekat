using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class V12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bioskopId",
                table: "Sale",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sale_bioskopId",
                table: "Sale",
                column: "bioskopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Bioskopi_bioskopId",
                table: "Sale",
                column: "bioskopId",
                principalTable: "Bioskopi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Bioskopi_bioskopId",
                table: "Sale");

            migrationBuilder.DropIndex(
                name: "IX_Sale_bioskopId",
                table: "Sale");

            migrationBuilder.DropColumn(
                name: "bioskopId",
                table: "Sale");
        }
    }
}
