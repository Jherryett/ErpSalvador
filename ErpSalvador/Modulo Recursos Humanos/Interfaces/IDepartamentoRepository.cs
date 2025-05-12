
namespace ErpSalvador.Interfaces
{
    public interface IDepartamentoRepository
    {
        Task<Departamento> CreateDepartamentoAsync(Departamento departamento);
        Task<Departamento> ReadDepartamentoAsync(int id);
        Task<IEnumerable<Departamento>> ReadAllDepartamentoAsync();
        Task<Departamento> UpdateDepartamentoAsync(Departamento departamento);       
        Task<bool> DeleteDepartamentoAsync(int id);
    }
}
