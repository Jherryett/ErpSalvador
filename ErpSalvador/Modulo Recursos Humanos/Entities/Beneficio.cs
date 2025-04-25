namespace ErpSalvador.Entities
{
    public class Beneficio
    {
        public int? Id { get; set; }
        public string? NomeBeneficio { get; set; }
        [Precision(18, 2)] public decimal? ValorBeneficio { get; set; }
        public string? Descritivo { get; set; }

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
