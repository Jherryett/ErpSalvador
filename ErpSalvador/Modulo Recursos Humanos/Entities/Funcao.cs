namespace ErpSalvador.Entities
{
    public class Funcao
    {
        public int? Id { get; set; }
        public int? IdFuncinario { get; set; }
        public int? IdDepartamento { get; set; }
        public string? NomeFuncao { get; set; }
        public string? DescritivoFuncao { get; set; }

        public Funcao() { }

        public Funcao(int id, int idFuncionario, int idDepartamento, string nomeFuncao, string descritivoFuncao)
        {
            Id = id;
            IdFuncinario = idFuncionario;
            IdDepartamento = idDepartamento;
            NomeFuncao = nomeFuncao;
            DescritivoFuncao = descritivoFuncao;
        }
    }
}
