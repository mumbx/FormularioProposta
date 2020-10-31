using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FormularioProposta.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataProposta",
                table: "Proposta",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataProposta",
                table: "Proposta",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
