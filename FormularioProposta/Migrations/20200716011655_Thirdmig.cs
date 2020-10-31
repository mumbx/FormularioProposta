using Microsoft.EntityFrameworkCore.Migrations;

namespace FormularioProposta.Migrations
{
    public partial class Thirdmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeCliente",
                table: "Proposta",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "PropostaVisualizada",
                table: "Proposta",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SegundoNomeCliente",
                table: "Proposta",
                maxLength: 25,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropostaVisualizada",
                table: "Proposta");

            migrationBuilder.DropColumn(
                name: "SegundoNomeCliente",
                table: "Proposta");

            migrationBuilder.AlterColumn<string>(
                name: "NomeCliente",
                table: "Proposta",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 25);
        }
    }
}
