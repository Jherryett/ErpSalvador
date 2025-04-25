using ErpSalvador.Interfaces;

namespace ErpSalvador.Services
{
    public class EnderecoFuncionarioService : IEnderecoFuncionarioService
    {

        private readonly IEnderecoFuncionarioRepository _enderecoFuncionarioRepository;

        public EnderecoFuncionarioService (IEnderecoFuncionarioRepository enderecoFuncionarioRepository)
        {
            _enderecoFuncionarioRepository = enderecoFuncionarioRepository;
        }

        public void ValidarEnderecoFuncionario()
        {
        



         
        }




    }
}
