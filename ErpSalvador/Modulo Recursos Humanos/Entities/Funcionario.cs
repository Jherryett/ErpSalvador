namespace ErpSalvador.Entities
{
    public class Funcionario
    {
        public int? Id { get; set; }
        public int? IdEnderecoFuncionario { get; set; }
        public int? IdBeneficio { get; set; }
        public string? NomeCompleto { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string? RgFuncionario { get; set; }
        public string? CpfFuncionario { get; set; }
        public string? Telefone1 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public string? Observacoes { get; set; }

        public Funcionario() { }

        public Funcionario(int id, int idEnderecoFuncionario, int idBeneficio, string nomeCompleto, DateOnly dataNascimento,
            string rgFuncionario, string cpfFuncionario, string telefone1, string telefone2, string email1, string email2, string observacoes)
        {
            Id = id;
            IdEnderecoFuncionario = idEnderecoFuncionario;
            IdBeneficio = idBeneficio;
            NomeCompleto = nomeCompleto;
            DataNascimento = dataNascimento;
            RgFuncionario = rgFuncionario;
            CpfFuncionario = cpfFuncionario;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Email1 = email1;
            Email2 = email2;
            Observacoes = observacoes;
        }

    }
}
