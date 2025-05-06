namespace ErpSalvador.Interfaces
{
    public interface IEnderecoFuncionarioRepository
    {
        void CreateEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal) { }
        EnderecoFuncionario ReadEnderecoFuncionario(int id);
        IEnumerable<EnderecoFuncionario> ReadAllEnderecoFuncionario();
        bool UpdateEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal);
        bool DeleteEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal);

    }
}
