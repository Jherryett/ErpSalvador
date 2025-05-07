namespace ErpSalvador.Services
{
    public class BeneficioService : IBeneficioService
    {
        private readonly IBeneficioRepository _beneficioRepository;

        public BeneficioService(IBeneficioRepository beneficioRepository)
        {
            _beneficioRepository = beneficioRepository;
        }

        public Beneficio ValidarBeneficio(Beneficio beneficio)
        {

            if (beneficio.NomeBeneficio == null)
                throw new ArgumentNullException("O nome é obrigatório");

            return (beneficio);
        }

        public async Task CriarBeneficio(Beneficio beneficio)
        {
            ValidarBeneficio(beneficio);

            await _beneficioRepository.CreateBeneficioAsync(beneficio);
        }

        public async Task<Beneficio> LerBeneficio(Beneficio beneficio)
        {
            var buscandoBeneficio = _beneficioRepository.ReadBeneficioAsync(beneficio.Id.Value);

            if (buscandoBeneficio == null)
            {
                throw new ArgumentNullException("Registro não encontrado");
            }

            else
            {
                return await (buscandoBeneficio);
            }
        }

        public async Task<IEnumerable<Beneficio>> LerTodosOsBeneficios()
        {
            var todosOsBeneficios = _beneficioRepository.ReadAllBeneficioAsync();
            return await todosOsBeneficios;
        }

        public async Task<bool> AtualizarBeneficio(Beneficio beneficio)
        {
            ValidarBeneficio(beneficio);
            Task<bool> retornoOperacao = _beneficioRepository.UpdateBeneficioAsync(beneficio);
            return await retornoOperacao;
        }

        public async Task<bool> ApagarBeneficio(Beneficio beneficio)
        {
            Task<bool> retornoOperacao = _beneficioRepository.DeleteBeneficioAsync(beneficio);
            return await retornoOperacao;
        }
    }
}
