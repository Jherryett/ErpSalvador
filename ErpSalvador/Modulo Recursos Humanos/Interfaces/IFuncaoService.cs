namespace ErpSalvador.Interfaces
{
    public interface IFuncaoService
    {
        public Funcao ValidarFuncao(Funcao funcao);
        Task<Funcao> CriarFuncaoAsync(Funcao funcao);
        Task<Funcao> LerFuncaoAsync(int id);
        Task<IEnumerable<Funcao>> LerTodasAsFuncoesAsync();
        Task<Funcao> AtualizarFuncaoAsync(Funcao funcao);
        Task<bool> ApagarFuncaoAsync(int id);
    }
}
