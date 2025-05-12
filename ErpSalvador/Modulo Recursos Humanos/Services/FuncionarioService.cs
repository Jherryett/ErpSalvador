namespace ErpSalvador.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public Funcionario ValidarFuncionario(Funcionario funcionario)
        {

            if (funcionario.NomeFuncionario == null)
                throw new ArgumentNullException("O nome é obrigatório");

            return (funcionario);
        }

        public async Task<Funcionario> CriarFuncionarioAsync(Funcionario funcionario)
        {
            ValidarFuncionario(funcionario);

            await _funcionarioRepository.CreateFuncionarioAsync(funcionario);
            return (funcionario);
        }

        public async Task<Funcionario> LerFuncionarioAsync(int id)
        {
            var buscandoBeneficio = _funcionarioRepository.ReadFuncionarioAsync(id);

            if (buscandoBeneficio == null)
            {
                throw new ArgumentNullException("Registro não encontrado");
            }

            else
            {
                return await (buscandoBeneficio);
            }
        }

        public async Task<IEnumerable<Funcionario>> LerTodosOsFuncionariosAsync()
        {
            var todosOsFuncionarios = _funcionarioRepository.ReadAllFuncionarioAsync();
            return await todosOsFuncionarios;
        }

        public async Task<Funcionario> AtualizarFuncionarioAsync(Funcionario funcionario)
        {
            ValidarFuncionario(funcionario);
            Task<Funcionario> retornoOperacao = _funcionarioRepository.UpdateFuncionarioAsync(funcionario);
            return await retornoOperacao;
        }

        public async Task<bool> ApagarFuncionarioAsync(int id)
        {
            Task<bool> retornoOperacao = _funcionarioRepository.DeleteFuncionarioAsync(id);
            return await retornoOperacao;
        }
    }
}
