using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ErpSalvador.Migrations
{
    /// <inheritdoc />
    public partial class RevisaoRh03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdBeneficio",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "IdEnderecoFuncionario",
                table: "Funcionarios");

            migrationBuilder.AddColumn<int>(
                name: "IdFuncionario",
                table: "EnderecoFuncionarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFuncionario",
                table: "Beneficios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_IdDepartamento",
                table: "Funcionarios",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_EnderecoFuncionarios_IdFuncionario",
                table: "EnderecoFuncionarios",
                column: "IdFuncionario",
                unique: true,
                filter: "[IdFuncionario] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficios_IdFuncionario",
                table: "Beneficios",
                column: "IdFuncionario");

            migrationBuilder.AddForeignKey(
                name: "FK_Beneficios_Funcionarios_IdFuncionario",
                table: "Beneficios",
                column: "IdFuncionario",
                principalTable: "Funcionarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecoFuncionarios_Funcionarios_IdFuncionario",
                table: "EnderecoFuncionarios",
                column: "IdFuncionario",
                principalTable: "Funcionarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Departamentos_IdDepartamento",
                table: "Funcionarios",
                column: "IdDepartamento",
                principalTable: "Departamentos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beneficios_Funcionarios_IdFuncionario",
                table: "Beneficios");

            migrationBuilder.DropForeignKey(
                name: "FK_EnderecoFuncionarios_Funcionarios_IdFuncionario",
                table: "EnderecoFuncionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Departamentos_IdDepartamento",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_IdDepartamento",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_EnderecoFuncionarios_IdFuncionario",
                table: "EnderecoFuncionarios");

            migrationBuilder.DropIndex(
                name: "IX_Beneficios_IdFuncionario",
                table: "Beneficios");

            migrationBuilder.DropColumn(
                name: "IdFuncionario",
                table: "EnderecoFuncionarios");

            migrationBuilder.DropColumn(
                name: "IdFuncionario",
                table: "Beneficios");

            migrationBuilder.AddColumn<int>(
                name: "IdBeneficio",
                table: "Funcionarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdEnderecoFuncionario",
                table: "Funcionarios",
                type: "int",
                nullable: true);
        }
    }
}
