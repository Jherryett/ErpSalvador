using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpSalvador.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoTabelaEnderecoFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroLocal",
                table: "EnderecoFuncionarios",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroLocal",
                table: "EnderecoFuncionarios");
        }
    }
}
