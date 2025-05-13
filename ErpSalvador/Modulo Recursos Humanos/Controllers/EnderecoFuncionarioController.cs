namespace ErpSalvador.Controllers
{
    [ApiController]
    [Route("api/endereco-funcionarios")]
    public class EnderecoFuncionarioController : ControllerBase // O controller não precisa de uma interface, pois o ASP net já faz isso, 
    {
        private readonly IEnderecoFuncionarioService _enderecoFuncionarioService; // Injeção de dependencia

        public EnderecoFuncionarioController(IEnderecoFuncionarioService enderecoFuncionarioService)
        {
            _enderecoFuncionarioService = enderecoFuncionarioService;
        }

        [HttpPost("adicionar")]
        public async Task <IActionResult> AdicionarEnderecosFuncionariosAsync([FromBody] EnderecoFuncionario enderecoFuncionario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _enderecoFuncionarioService.CriarEnderecoFuncionarioAsync(enderecoFuncionario);
                return StatusCode(StatusCodes.Status201Created, enderecoFuncionario);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao adicionar o endereço.");
            }
        }


        [HttpGet("obter/{id}")]
        public async Task <EnderecoFuncionario> ObterEnderecoFuncionarioAsync(int id) 
        {
            var enderecoFuncionario = await _enderecoFuncionarioService.LerEnderecoFuncionarioAsync(id);
            return enderecoFuncionario;        
        }

        [HttpGet("obter-todos")]

        public async Task<ActionResult<IEnumerable<EnderecoFuncionario>>> ObterTodosEnderecosFuncionarios()
        {
            try
            {
                IEnumerable<EnderecoFuncionario> enderecos = await _enderecoFuncionarioService.LerTodosOsEnderecosFuncionariosAsync();
                return Ok(enderecos);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao obter os endereços.");
            }

        }

        [HttpPut("atualizar")]

        public async Task <IActionResult> AtualizarEnderecoFuncionarios([FromBody] EnderecoFuncionario enderecoFuncionario)
        {
            if (enderecoFuncionario == null)
                return BadRequest(ModelState);

            try
            {
                await _enderecoFuncionarioService.AtualizarEnderecoFuncionarioAsync(enderecoFuncionario);
                return Ok(enderecoFuncionario);
            }


            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao atualizar o endereço.");
            }
        }

        [HttpDelete("apagar/{id}")]

        public async Task <IActionResult> ApagarEnderecoFuncionarios([FromBody] int id)
        {
            Task enderecoFuncionario = _enderecoFuncionarioService.LerEnderecoFuncionarioAsync(id);

            if (enderecoFuncionario == null)
                return BadRequest(ModelState);

            try
            {
                await _enderecoFuncionarioService.ApagarEnderecoFuncionarioAsync(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Erro interno ao apagar o endereço.");
            }
        }
    }
}
