namespace ErpSalvador.Interfaces
{
    public interface IEnderecoFuncionarioRepository
    {
        void CreateEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal) { }
        EnderecoFuncionario? ReadEnderecoFuncionario(int id);
        bool UpdateEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal);
        bool DeleteEnderecoFuncionario(EnderecoFuncionario enderecoFuncionarioFinal);

    }
}
