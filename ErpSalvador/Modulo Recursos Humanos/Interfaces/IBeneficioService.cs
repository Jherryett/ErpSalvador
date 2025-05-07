namespace ErpSalvador.Interfaces
{
    public interface IBeneficioService
    {
        void ValidarBeneficio() { }

        Task CriarBeneficio(Beneficio beneficio);

        Task <Beneficio> LerBeneficio(Beneficio beneficio);

        Task <IEnumerable<Beneficio>> LerTodosOsBeneficios();

        Task <bool> AtualizarBeneficio(Beneficio beneficio);

        Task<bool> ApagarBeneficio(Beneficio beneficio);
    }
}
