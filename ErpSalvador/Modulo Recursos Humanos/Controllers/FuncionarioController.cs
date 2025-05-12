namespace ErpSalvador.Controllers
{
    [ApiController]
    [Route("api/funcionario")]

    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostFuncionarioAsync([FromBody] Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _funcionarioService.CriarFuncionarioAsync(funcionario);
                return StatusCode(StatusCodes.Status201Created);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("obter/{id}")]
        public async Task<IActionResult> GetFuncionarioAsync(int id)
        {

            try
            {
                Funcionario funcionarioFinal = await _funcionarioService.LerFuncionarioAsync(id);

                return Ok(funcionarioFinal);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("obter-todos")]
        public async Task<ActionResult<IEnumerable<Funcionario>>> GetAllFuncionarioAsync()
        {
            try
            {
                IEnumerable<Funcionario> todosOsRegistros = await _funcionarioService.LerTodosOsFuncionariosAsync();
                return Ok(todosOsRegistros);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpPut("atualizar")]
        public async Task <IActionResult> UpdateFuncionarioAsync([FromBody] Funcionario funcionario) 
        {
            if (funcionario == null)
                return BadRequest(ModelState);

            try
            {
                await _funcionarioService.AtualizarFuncionarioAsync(funcionario);
                return Ok(funcionario);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        
        [HttpDelete("apagar/{id}")] // É necessário receber o id na URL, porque quando se trata de apagar/delete, o APS.NET não converte um dado só do corpo, igual ocorre com uma atualização/Put, questão de bidding
                
        public async Task <IActionResult> DeleteFuncionarioAsync(int id ) 
        {
            if(id <= 0)
                return BadRequest(ModelState);

            try 
            {                
                await _funcionarioService.ApagarFuncionarioAsync(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

    }
}
