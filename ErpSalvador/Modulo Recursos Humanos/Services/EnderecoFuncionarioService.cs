namespace ErpSalvador.Services
{
    public class EnderecoFuncionarioService : IEnderecoFuncionarioService
    {

        private readonly IEnderecoFuncionarioRepository _enderecoFuncionarioRepository;

        public EnderecoFuncionarioService(IEnderecoFuncionarioRepository enderecoFuncionarioRepository)
        {
            _enderecoFuncionarioRepository = enderecoFuncionarioRepository;
        }

        public EnderecoFuncionario ValidarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario)
        {

            if (string.IsNullOrEmpty(enderecoFuncionario.NomeRua))
                throw new ArgumentException("o nome da Rua deve ser informada", nameof(enderecoFuncionario.NomeRua));
            if (string.IsNullOrEmpty(enderecoFuncionario.NumeroCep))
                throw new ArgumentException("O número do CEP deve ser informado", nameof(enderecoFuncionario.NumeroCep));

            else return (enderecoFuncionario);
        }


        public async Task<EnderecoFuncionario> CriarEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionario)
        {
            ValidarEnderecoFuncionario(enderecoFuncionario);

            await _enderecoFuncionarioRepository.CreateEnderecoFuncionarioAsync(enderecoFuncionario);
            return (enderecoFuncionario);
        }

        public  Task <EnderecoFuncionario> LerEnderecoFuncionarioAsync(int id)
        {
            var buscandoEndereco = _enderecoFuncionarioRepository.ReadEnderecoFuncionarioAsync(id);

            if (buscandoEndereco == null)
            {
                throw new ArgumentException("Registro não encontrado");
            }

            else
            {
                return buscandoEndereco;
            }

        }

        public async Task<IEnumerable<EnderecoFuncionario>> LerTodosOsEnderecosFuncionariosAsync() 
        {
            var todosOsEnderecos = await _enderecoFuncionarioRepository.ReadAllEnderecoFuncionarioAsync();
            return todosOsEnderecos;
        } 

        public async Task<EnderecoFuncionario> AtualizarEnderecoFuncionarioAsync(EnderecoFuncionario enderecoFuncionario)
        {
            ValidarEnderecoFuncionario(enderecoFuncionario);

            EnderecoFuncionario RetornoOperacao = await _enderecoFuncionarioRepository.UpdateEnderecoFuncionarioAsync(enderecoFuncionario);
            return RetornoOperacao;
        }


        public async Task <bool> ApagarEnderecoFuncionarioAsync(int id)
        {
            Task <bool> RetornoOperacao = _enderecoFuncionarioRepository.DeleteEnderecoFuncionarioAsync(id);
            return await RetornoOperacao;
        }

    }
}
