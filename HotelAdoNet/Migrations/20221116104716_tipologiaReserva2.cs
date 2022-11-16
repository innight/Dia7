using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelAdoNet.Migrations
{
    public partial class tipologiaReserva2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Tipologias_TipologiaId",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "TipologiaId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Tipologias_TipologiaId",
                table: "Reservas",
                column: "TipologiaId",
                principalTable: "Tipologias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Tipologias_TipologiaId",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "TipologiaId",
                table: "Reservas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Tipologias_TipologiaId",
                table: "Reservas",
                column: "TipologiaId",
                principalTable: "Tipologias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
