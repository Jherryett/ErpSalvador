namespace ErpSalvador.Interfaces
{
    public interface IEnderecoFuncionarioRepository
    {
        Task<EnderecoFuncionario> CreateEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionarioFinal);
        Task<EnderecoFuncionario> ReadEnderecoFuncionarioAsync(int id);
        Task <IEnumerable<EnderecoFuncionario>> ReadAllEnderecoFuncionarioAsync();
        Task<EnderecoFuncionario> UpdateEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionarioFinal);
        Task <bool> DeleteEnderecoFuncionarioAsync(int id);

    }
}
