namespace ErpSalvador.Interfaces
{
    public interface IEnderecoFuncionarioService
    {
        public EnderecoFuncionario ValidarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario);

        Task<EnderecoFuncionario> CriarEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionario);

        Task <EnderecoFuncionario> LerEnderecoFuncionarioAsync(int id);

        Task <IEnumerable<EnderecoFuncionario>> LerTodosOsEnderecosFuncionariosAsync();

        Task <EnderecoFuncionario> AtualizarEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionario);

        Task <bool> ApagarEnderecoFuncionarioAsync(int id);
    }
}
