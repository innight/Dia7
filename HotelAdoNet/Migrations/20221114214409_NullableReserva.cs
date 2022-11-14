using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelAdoNet.Migrations
{
    public partial class NullableReserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Quartos_QuartoId",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "QuartoId",
                table: "Reservas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Quartos_QuartoId",
                table: "Reservas",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Quartos_QuartoId",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "QuartoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Quartos_QuartoId",
                table: "Reservas",
                column: "QuartoId",
                principalTable: "Quartos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
