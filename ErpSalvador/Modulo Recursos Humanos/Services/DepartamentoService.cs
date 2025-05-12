namespace ErpSalvador.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoService(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        public Departamento ValidarDepartamento(Departamento departamento)
        {

            if (departamento.NomeDepartamento == null)
                throw new ArgumentNullException("O nome é obrigatório");

            return (departamento);
        }

        public async Task<Departamento> CriarDepartamentoAsync(Departamento departamento)
        {
            ValidarDepartamento(departamento);

            await _departamentoRepository.CreateDepartamentoAsync(departamento);
            return (departamento);
        }

        public async Task<Departamento> LerDepartamentoAsync(int id)
        {
            var buscandoBeneficio = _departamentoRepository.ReadDepartamentoAsync(id);

            if (buscandoBeneficio == null)
            {
                throw new ArgumentNullException("Registro não encontrado");
            }

            else
            {
                return await (buscandoBeneficio);
            }
        }

        public async Task<IEnumerable<Departamento>> LerTodosOsDepartamentosAsync()
        {
            var todosOsDepartamentos = _departamentoRepository.ReadAllDepartamentoAsync();
            return await todosOsDepartamentos;
        }

        public async Task<Departamento> AtualizarDepartamentoAsync(Departamento departamento)
        {
            ValidarDepartamento(departamento);
            Task<Departamento> retornoOperacao = _departamentoRepository.UpdateDepartamentoAsync(departamento);
            return await retornoOperacao;
        }

        public async Task<bool> ApagarDepartamentoAsync(int id)
        {
            Task<bool> retornoOperacao = _departamentoRepository.DeleteDepartamentoAsync(id);
            return await retornoOperacao;
        }
    }
}
