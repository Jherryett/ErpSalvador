namespace ErpSalvador.Controllers
{
    [ApiController]
    [Route("api/enderecos-funcionarios")]
    public class EnderecoFuncionarioController : ControllerBase // O controller não precisa de uma interface, pois o ASP net já faz isso, 
    {
        private readonly IEnderecoFuncionarioService _enderecoFuncionarioService; // Injeção de dependencia

        public EnderecoFuncionarioController(IEnderecoFuncionarioService enderecoFuncionarioService)
        {
            _enderecoFuncionarioService = enderecoFuncionarioService;
        }

        [HttpPost("Adicionar")]
        public IActionResult AdicionarEnderecosFuncionarios([FromBody] EnderecoFuncionario enderecoFuncionario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _enderecoFuncionarioService.CriarEnderecoFuncionario(enderecoFuncionario);
                return StatusCode(StatusCodes.Status201Created, enderecoFuncionario);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao adicionar o endereço.");
            }
        }
        [HttpGet("Obter")]

        public ActionResult<IEnumerable<EnderecoFuncionario>> ObterTodosEnderecosFuncionarios()
        {
            try
            {
                IEnumerable<EnderecoFuncionario> enderecos = _enderecoFuncionarioService.LerTodosOsEnderecosFuncionarios();
                return Ok(enderecos);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao obter os endereços.");
            }

        }

        [HttpPut("Atualizar")]

        public IActionResult AtualizarEnderecoFuncionarios([FromBody] EnderecoFuncionario enderecoFuncionario)
        {
            if (enderecoFuncionario == null)
                return BadRequest(ModelState);

            try
            {
                _enderecoFuncionarioService.AtualizarEnderecoFuncionario(enderecoFuncionario);
                return Ok(enderecoFuncionario);
            }


            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao atualizar o endereço.");
            }
        }

        [HttpDelete("Apagar")]

        public IActionResult ApagarEnderecoFuncionarios([FromBody] EnderecoFuncionario enderecoFuncionario)
        {
            if (enderecoFuncionario == null)
                return BadRequest(ModelState);

            try
            {
                _enderecoFuncionarioService.ApagarEnderecoFuncionario(enderecoFuncionario);
                return NoContent();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao apagar o endereço.");
            }
        }
    }
}
