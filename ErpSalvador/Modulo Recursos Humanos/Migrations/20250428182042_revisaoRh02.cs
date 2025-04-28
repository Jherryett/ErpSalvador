using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpSalvador.Migrations
{
    /// <inheritdoc />
    public partial class revisaoRh02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdFuncinario",
                table: "Funcoes");

            migrationBuilder.AddColumn<int>(
                name: "IdDepartamento",
                table: "Funcionarios",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDepartamento",
                table: "Funcionarios");

            migrationBuilder.AddColumn<int>(
                name: "IdFuncinario",
                table: "Funcoes",
                type: "int",
                nullable: true);
        }
    }
}
