using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelAdoNet.Migrations
{
    public partial class FotoQuartos_Reservas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FotoId",
                table: "Quartos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FotoQuartoid",
                table: "Quartos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservaId",
                table: "Quartos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FotosQuartos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotosQuartos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_FotoQuartoid",
                table: "Quartos",
                column: "FotoQuartoid");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_ReservaId",
                table: "Quartos",
                column: "ReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quartos_FotosQuartos_FotoQuartoid",
                table: "Quartos",
                column: "FotoQuartoid",
                principalTable: "FotosQuartos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Quartos_Reservas_ReservaId",
                table: "Quartos",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_FotosQuartos_FotoQuartoid",
                table: "Quartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_Reservas_ReservaId",
                table: "Quartos");

            migrationBuilder.DropTable(
                name: "FotosQuartos");

            migrationBuilder.DropIndex(
                name: "IX_Quartos_FotoQuartoid",
                table: "Quartos");

            migrationBuilder.DropIndex(
                name: "IX_Quartos_ReservaId",
                table: "Quartos");

            migrationBuilder.DropColumn(
                name: "FotoId",
                table: "Quartos");

            migrationBuilder.DropColumn(
                name: "FotoQuartoid",
                table: "Quartos");

            migrationBuilder.DropColumn(
                name: "ReservaId",
                table: "Quartos");
        }
    }
}
