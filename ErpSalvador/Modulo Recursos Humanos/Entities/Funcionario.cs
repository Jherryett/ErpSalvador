namespace ErpSalvador.Entities
{
    public class Funcionario
    {
        public int? Id { get; set; }
        public int? IdDepartamento { get; set; }

        public string? NomeCompleto { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string? RgFuncionario { get; set; }
        public string? CpfFuncionario { get; set; }
        public string? Telefone1 { get; set; }
        public string? Telefone2 { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public string? Observacoes { get; set; }

        [ForeignKey("IdDepartamento")]  public Departamento? Departamentos { get; set; } // Propriedade de navegação do Entity framework
        public EnderecoFuncionario? EnderecoFuncionarios { get; set; }
        public ICollection<Beneficio>? Beneficios { get; set; }


        public Funcionario() { }

        public Funcionario(int id, int idDepartamento, string nomeCompleto, DateOnly dataNascimento,
            string rgFuncionario, string cpfFuncionario, string telefone1, string telefone2, string email1, string email2, string observacoes)
        {
            Id = id;
            IdDepartamento = idDepartamento;
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
