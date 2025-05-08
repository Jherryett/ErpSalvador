namespace ErpSalvador.Interfaces
{
    public interface IBeneficioService
    {
        void ValidarBeneficio() { }

        Task CriarBeneficio(Beneficio beneficio);

        Task <Beneficio> LerBeneficio(int id);

        Task <IEnumerable<Beneficio>> LerTodosOsBeneficios();

        Task <bool> AtualizarBeneficio(Beneficio beneficio);

        Task<bool> ApagarBeneficio(int id);
    }
}
