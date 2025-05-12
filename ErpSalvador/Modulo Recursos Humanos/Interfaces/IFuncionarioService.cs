namespace ErpSalvador.Interfaces
{
    public interface IFuncionarioService
    {
        public Funcionario ValidarFuncionario(Funcionario funcionario);
        Task<Funcionario> CriarFuncionarioAsync(Funcionario funcionario);
        Task<Funcionario> LerFuncionarioAsync(int id);
        Task<IEnumerable<Funcionario>> LerTodosOsFuncionariosAsync();
        Task<Funcionario> AtualizarFuncionarioAsync(Funcionario funcionario);
        Task<bool> ApagarFuncionarioAsync(int id);
    }
}
