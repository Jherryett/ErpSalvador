namespace ErpSalvador.Services
{
    public class FuncaoService : IFuncaoService
    {
        private readonly IFuncaoRepository _funcaoRepository;

        public FuncaoService(IFuncaoRepository funcaoRepository)
        {
            _funcaoRepository = funcaoRepository;
        }

        public Funcao ValidarFuncao(Funcao funcao)
        {

            if (funcao.NomeFuncao == null)
                throw new ArgumentNullException("O nome é obrigatório");

            return (funcao);
        }

        public async Task<Funcao> CriarFuncaoAsync(Funcao funcao)
        {
            ValidarFuncao(funcao);

            await _funcaoRepository.CreateFuncaoAsync(funcao);
            return (funcao);
        }

        public async Task<Funcao> LerFuncaoAsync(int id)
        {
            var buscandoBeneficio = _funcaoRepository.ReadFuncaoAsync(id);

            if (buscandoBeneficio == null)
            {
                throw new ArgumentNullException("Registro não encontrado");
            }

            else
            {
                return await (buscandoBeneficio);
            }
        }

        public async Task<IEnumerable<Funcao>> LerTodasAsFuncoesAsync()
        {
            var todosOsFuncaos = _funcaoRepository.ReadAllFuncaoAsync();
            return await todosOsFuncaos;
        }

        public async Task<Funcao> AtualizarFuncaoAsync(Funcao funcao)
        {
            ValidarFuncao(funcao);
            Task<Funcao> retornoOperacao = _funcaoRepository.UpdateFuncaoAsync(funcao);
            return await retornoOperacao;
        }

        public async Task<bool> ApagarFuncaoAsync(int id)
        {
            Task<bool> retornoOperacao = _funcaoRepository.DeleteFuncaoAsync(id);
            return await retornoOperacao;
        }
    }
}
