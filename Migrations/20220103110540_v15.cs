using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bioskop.Migrations
{
    public partial class v15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumRodj",
                table: "Korisnici");

            migrationBuilder.AddColumn<bool>(
                name: "admin",
                table: "Korisnici",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "admin",
                table: "Korisnici");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumRodj",
                table: "Korisnici",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
