namespace ErpSalvador.Interfaces
{
    public interface IEnderecoFuncionarioService
    {
        void ValidarEnderecoFuncionario() { }

        void CriarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario) { }

        EnderecoFuncionario LerEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario);

        IEnumerable<EnderecoFuncionario> LerTodosOsEnderecosFuncionarios();

        bool AtualizarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario);

        bool ApagarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario);

    }
}
