namespace ErpSalvador.Entities
{
    public class Departamento
    {
        public int? Id { get; set; }
        public string? NomeDepartamento { get; set; }
        public string? DescritivoDepartamento { get; set; }

        public Departamento() { }
        public Departamento(int id, string nomeDepartamento, string descritivoDepartamento)
        {
            Id = id;
            NomeDepartamento = nomeDepartamento;
            DescritivoDepartamento = descritivoDepartamento;
        }
    }
}
