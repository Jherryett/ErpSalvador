
namespace ErpSalvador.Interfaces
{
    public interface IFuncionarioRepository
    {
        Task<Funcionario> CreateFuncionarioAsync(Funcionario funcionario);
        Task<Funcionario> ReadFuncionarioAsync(int id);
        Task<IEnumerable<Funcionario>> ReadAllFuncionarioAsync();
        Task<Funcionario> UpdateFuncionarioAsync(Funcionario funcionario);       
        Task<bool> DeleteFuncionarioAsync(int id);
    }
}
