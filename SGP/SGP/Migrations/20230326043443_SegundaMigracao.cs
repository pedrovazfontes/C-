using Microsoft.EntityFrameworkCore.Migrations;

namespace SGP.Migrations
{
    public partial class SegundaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Pago",
                table: "Pedidos",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AddColumn<string>(
                name: "FormadePgto",
                table: "Pedidos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormadePgto",
                table: "Pedidos");

            migrationBuilder.AlterColumn<bool>(
                name: "Pago",
                table: "Pedidos",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }
    }
}
