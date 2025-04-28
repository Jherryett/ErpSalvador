namespace ErpSalvador.Entities
{
    public class Beneficio
    {
        public int? Id { get; set; }
        public int? IdFuncionario { get; set; }
        public string? NomeBeneficio { get; set; }
        [Precision(18, 2)] public decimal? ValorBeneficio { get; set; }
        public string? Descritivo { get; set; }

        [ForeignKey("IdFuncionario")] public Funcionario? Funcionario { get; set; } // Isso aqui é chamado de propriedade de navegação, é usadado pelo Entity Framework

        public Beneficio() { }
        public Beneficio(int id, string nomeBeneficio, decimal valorBeneficio, string descritivo)
        {
            Id = id;
            NomeBeneficio = nomeBeneficio;
            ValorBeneficio = valorBeneficio;
            Descritivo = descritivo;
        }
    }
}
