namespace ErpSalvador.Entities
{
    public class Beneficio
    {
        public int? Id { get; set; }
        [Precision(18, 2)] public string? NomeBeneficio { get; set; }
        public decimal? ValorBeneficio { get; set; }
        public string? Descritivo { get; set; }
    }
}
