using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelAdoNet.Migrations
{
    public partial class RelationOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipologiaId",
                table: "Quartos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quartos_TipologiaId",
                table: "Quartos",
                column: "TipologiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quartos_Tipologias_TipologiaId",
                table: "Quartos",
                column: "TipologiaId",
                principalTable: "Tipologias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quartos_Tipologias_TipologiaId",
                table: "Quartos");

            migrationBuilder.DropIndex(
                name: "IX_Quartos_TipologiaId",
                table: "Quartos");

            migrationBuilder.DropColumn(
                name: "TipologiaId",
                table: "Quartos");
        }
    }
}
