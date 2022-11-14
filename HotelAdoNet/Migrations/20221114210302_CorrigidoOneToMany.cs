using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelAdoNet.Migrations
{
    public partial class CorrigidoOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_FotosQuartos_FotoQuartoid",
                table: "Quartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_Reservas_ReservaId",
                table: "Quartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_Tipologias_TipologiaId",
                table: "Quartos");

            migrationBuilder.DropIndex(
                name: "IX_Quartos_FotoQuartoid",
                table: "Quartos");

            migrationBuilder.DropIndex(
                name: "IX_Quartos_ReservaId",
                table: "Quartos");

            migrationBuilder.DropIndex(
                name: "IX_Quartos_TipologiaId",
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

            migrationBuilder.DropColumn(
                name: "TipologiaId",
                table: "Quartos");

            migrationBuilder.AddColumn<int>(
                name: "QuartoId",
                table: "Tipologias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuartoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuartoId",
                table: "FotosQuartos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tipologias_QuartoId",
                table: "Tipologias",
                column: "QuartoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_QuartoId",
                table: "Reservas",
                column: "QuartoId");

            migrationBuilder.CreateIndex(
                name: "IX_FotosQuartos_QuartoId",
                table: "FotosQuartos",
                column: "QuartoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FotosQuartos_Quartos_QuartoId",
                table: "FotosQuartos",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Quartos_QuartoId",
                table: "Reservas",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipologias_Quartos_QuartoId",
                table: "Tipologias",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FotosQuartos_Quartos_QuartoId",
                table: "FotosQuartos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Quartos_QuartoId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipologias_Quartos_QuartoId",
                table: "Tipologias");

            migrationBuilder.DropIndex(
                name: "IX_Tipologias_QuartoId",
                table: "Tipologias");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_QuartoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_FotosQuartos_QuartoId",
                table: "FotosQuartos");

            migrationBuilder.DropColumn(
                name: "QuartoId",
                table: "Tipologias");

            migrationBuilder.DropColumn(
                name: "QuartoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "QuartoId",
                table: "FotosQuartos");

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

            migrationBuilder.AddColumn<int>(
                name: "TipologiaId",
                table: "Quartos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_FotoQuartoid",
                table: "Quartos",
                column: "FotoQuartoid");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_ReservaId",
                table: "Quartos",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_TipologiaId",
                table: "Quartos",
                column: "TipologiaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Quartos_Tipologias_TipologiaId",
                table: "Quartos",
                column: "TipologiaId",
                principalTable: "Tipologias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
