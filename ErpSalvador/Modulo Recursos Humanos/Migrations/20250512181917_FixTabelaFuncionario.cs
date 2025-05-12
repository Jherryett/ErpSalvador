using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpSalvador.Migrations
{
    /// <inheritdoc />
    public partial class FixTabelaFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeCompleto",
                table: "Funcionarios",
                newName: "NomeFuncionario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NomeFuncionario",
                table: "Funcionarios",
                newName: "NomeCompleto");
        }
    }
}
