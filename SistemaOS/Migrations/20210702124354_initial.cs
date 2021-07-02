using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaOS.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroOS = table.Column<int>(nullable: false),
                    TituloServico = table.Column<string>(type: "varchar(50)", nullable: false),
                    NomeCliente = table.Column<string>(type: "varchar(100)", nullable: false),
                    CNPJCliente = table.Column<string>(type: "varchar(20)", nullable: false),
                    NomePrestador = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPFPrestador = table.Column<string>(type: "varchar(15)", nullable: false),
                    DataExecucao = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdemServico");
        }
    }
}
