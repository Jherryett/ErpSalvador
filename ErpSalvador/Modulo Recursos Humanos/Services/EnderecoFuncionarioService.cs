
using System.Collections.Generic;

namespace ErpSalvador.Services
{
    public class EnderecoFuncionarioService : IEnderecoFuncionarioService
    {

        private readonly IEnderecoFuncionarioRepository _enderecoFuncionarioRepository;

        public EnderecoFuncionarioService(IEnderecoFuncionarioRepository enderecoFuncionarioRepository)
        {
            _enderecoFuncionarioRepository = enderecoFuncionarioRepository;
        }



        public EnderecoFuncionario ValidarEnderecoFuncionario(EnderecoFuncionario validarEnderecoFuncionario)
        {

            if (string.IsNullOrEmpty(validarEnderecoFuncionario.NomeRua))
                throw new ArgumentException("O nome da rua deve ser informado", nameof(validarEnderecoFuncionario.NomeRua));


            if (string.IsNullOrEmpty(validarEnderecoFuncionario.NumeroCep))
                throw new ArgumentException("O número do CEP deve ser informado", nameof(validarEnderecoFuncionario.NumeroCep));

            return (validarEnderecoFuncionario);

        }


        public void CriarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario)
        {
            ValidarEnderecoFuncionario(enderecoFuncionario);

            _enderecoFuncionarioRepository.CreateEnderecoFuncionario(enderecoFuncionario);
        }

        public EnderecoFuncionario LerEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario)
        {
            var buscandoEndereco = _enderecoFuncionarioRepository.ReadEnderecoFuncionario(enderecoFuncionario.Id.Value);

            if (buscandoEndereco == null)
            {
                throw new ArgumentException("Registro não encontrado");
            }

            else
            {
                return buscandoEndereco;
            }

        }

        public IEnumerable<EnderecoFuncionario> LerTodosOsEnderecosFuncionarios() 
        {
            var todosOsEnderecos = _enderecoFuncionarioRepository.ReadAllEnderecoFuncionario();
            return todosOsEnderecos;
        } 








        public bool AtualizarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario)
        {
            ValidarEnderecoFuncionario(enderecoFuncionario);

            bool RetornoOperacao = _enderecoFuncionarioRepository.UpdateEnderecoFuncionario(enderecoFuncionario);
            return RetornoOperacao;
        }


        public bool ApagarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario)
        {
            bool RetornoOperacao = _enderecoFuncionarioRepository.DeleteEnderecoFuncionario(enderecoFuncionario);
            return RetornoOperacao;
        }

    }
}
