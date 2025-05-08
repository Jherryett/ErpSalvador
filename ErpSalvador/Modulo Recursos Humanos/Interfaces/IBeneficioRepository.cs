namespace ErpSalvador.Interfaces
{
    public interface IBeneficioRepository
    {
        Task CreateBeneficioAsync(Beneficio beneficioFinal);
        Task <Beneficio> ReadBeneficioAsync(int id);
        Task <IEnumerable<Beneficio>> ReadAllBeneficioAsync();
        Task <bool> UpdateBeneficioAsync(Beneficio beneficioFinal);
        Task <bool> DeleteBeneficioAsync(int id);
    }
}
