using ErpSalvador.Interfaces;
using Microsoft.IdentityModel.Tokens;

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



        public void AtualizarEnderecoFuncionario(EnderecoFuncionario enderecoFuncionario)
        {
            ValidarEnderecoFuncionario(enderecoFuncionario);

            _enderecoFuncionarioRepository.UpdateEnderecoFuncionario(enderecoFuncionario);
        }








    }
}
