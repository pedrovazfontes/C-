using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGP.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormadePgto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormadePgto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false, defaultValueSql: "GEDATE()"),
                    NomeProduto = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    formadeEntrega = table.Column<string>(nullable: false),
                    Pago = table.Column<bool>(type: "BIT()", nullable: false),
                    Valor = table.Column<double>(type: "FLOAT()", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                    Nome = table.Column<string>(type: "VARCHAR(40)", nullable: true),
                    Descricao = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    ValorCompra = table.Column<double>(type: "FLOAT", nullable: false),
                    ValorVenda = table.Column<float>(nullable: false, defaultValue: 0f),
                    Lucro = table.Column<float>(nullable: false, defaultValue: 0f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormadePgto");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
