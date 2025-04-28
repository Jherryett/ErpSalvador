using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpSalvador.Migrations
{
    /// <inheritdoc />
    public partial class revisaorh01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdBeneficios",
                table: "Funcionarios",
                newName: "IdBeneficio");

            migrationBuilder.AddColumn<string>(
                name: "NumeroCep",
                table: "EnderecoFuncionarios",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroCep",
                table: "EnderecoFuncionarios");

            migrationBuilder.RenameColumn(
                name: "IdBeneficio",
                table: "Funcionarios",
                newName: "IdBeneficios");
        }
    }
}
