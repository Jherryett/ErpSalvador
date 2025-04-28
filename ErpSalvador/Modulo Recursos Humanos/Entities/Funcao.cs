

namespace ErpSalvador.Entities
{
    public class Funcao
    {
        public int? Id { get; set; }

        [ForeignKey("Departamento")] public int? IdDepartamento { get; set; }
        public string? NomeFuncao { get; set; }
        public string? DescritivoFuncao { get; set; }

        public Funcao() { }

        public Funcao(int id, int idDepartamento, string nomeFuncao, string descritivoFuncao)
        {
            Id = id;
            IdDepartamento = idDepartamento;
            NomeFuncao = nomeFuncao;
            DescritivoFuncao = descritivoFuncao;
        }
    }
}
