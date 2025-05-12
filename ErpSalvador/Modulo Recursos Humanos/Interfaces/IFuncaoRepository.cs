
namespace ErpSalvador.Interfaces
{
    public interface IFuncaoRepository
    {
        Task<Funcao> CreateFuncaoAsync(Funcao funcao);
        Task<Funcao> ReadFuncaoAsync(int id);
        Task<IEnumerable<Funcao>> ReadAllFuncaoAsync();
        Task<Funcao> UpdateFuncaoAsync(Funcao funcao);       
        Task<bool> DeleteFuncaoAsync(int id);
    }
}
