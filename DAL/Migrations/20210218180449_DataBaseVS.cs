using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class DataBaseVS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContasPagarId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DespesasId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "GanhosId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "SaldoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "RemuneracaoFamilia",
                table: "RemuneracoesTotais");

            migrationBuilder.DropColumn(
                name: "data",
                table: "Ganhos");

            migrationBuilder.DropColumn(
                name: "DataPagar",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "RemuneracaoIndividual",
                table: "RemuneracoesTotais",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "ValorConta",
                table: "Contas",
                newName: "Valor");

            migrationBuilder.AddColumn<string>(
                name: "Motivo",
                table: "RemuneracoesTotais",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Motivo",
                table: "RemuneracoesTotais");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "RemuneracoesTotais",
                newName: "RemuneracaoIndividual");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Contas",
                newName: "ValorConta");

            migrationBuilder.AddColumn<int>(
                name: "ContasPagarId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DespesasId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GanhosId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaldoId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "RemuneracaoFamilia",
                table: "RemuneracoesTotais",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "data",
                table: "Ganhos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPagar",
                table: "Contas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
