namespace ErpSalvador.Entities
{
    public class EnderecoFuncionario

    {
        public int? Id { get; set; }
        public int? IdFuncionario { get; set; } 
        public string? NomeRua { get; set; }
        public string? NomeBairro { get; set; }
        public string? NomeCidade { get; set; }
        public string? NomeEstado { get; set; }
        public string? NumeroCep { get; set; }
        public string? Complemento1 { get; set; }
        public string? Complemento2 { get; set; }
        public DateTime DataCadastro { get; set; }

        [ForeignKey("IdFuncionario")]public Funcionario? Funcionario { get; set; }

        public EnderecoFuncionario() { }
        public EnderecoFuncionario(int id, string nomeRua, string nomeBairro, string nomeCidade, string nomeEstado,string numeroCep, string complemento1, string complemento2, DateTime dataCadastro)

        {
            Id = id;
            NomeRua = nomeRua;
            NomeBairro = nomeBairro;
            NomeCidade = nomeCidade;
            NomeEstado = nomeEstado;
            NumeroCep = numeroCep;
            Complemento1 = complemento1;
            Complemento2 = complemento2;
            DataCadastro = dataCadastro;
        }

    }
}
