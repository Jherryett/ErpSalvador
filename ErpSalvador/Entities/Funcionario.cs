namespace ErpSalvador.Entities
{
    public class Funcionario
    {
        public int? Id { get; set; }
        public int? IdEnderecoFuncionario { get; set; }
        public int? IdBeneficios { get; set; }
        public string? NomeCompleto { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string? RgFuncionario { get; set; }
        public string? CpfFuncionario { get; set; }
        public string? Telefone1 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public string? Observacoes { get; set; }

    }
}
