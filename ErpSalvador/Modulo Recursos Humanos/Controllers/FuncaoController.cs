namespace ErpSalvador.Controllers
{
    [ApiController]
    [Route("api/funcao")]

    public class FuncaoController : ControllerBase
    {
        private readonly IFuncaoService _funcaoService;

        public FuncaoController(IFuncaoService funcaoService)
        {
            _funcaoService = funcaoService;
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostFuncaoAsync([FromBody] Funcao funcao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _funcaoService.CriarFuncaoAsync(funcao);
                return StatusCode(StatusCodes.Status201Created);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("obter/{id}")]
        public async Task<IActionResult> GetFuncaoAsync(int id)
        {

            try
            {
                Funcao funcaoFinal = await _funcaoService.LerFuncaoAsync(id);

                return Ok(funcaoFinal);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("obter-todos")]
        public async Task<ActionResult<IEnumerable<Funcao>>> GetAllFuncaoAsync()
        {
            try
            {
                IEnumerable<Funcao> todosOsRegistros = await _funcaoService.LerTodasAsFuncoesAsync();
                return Ok(todosOsRegistros);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpPut("atualizar")]
        public async Task <IActionResult> UpdateFuncaoAsync([FromBody] Funcao funcao) 
        {
            if (funcao == null)
                return BadRequest(ModelState);

            try
            {
                await _funcaoService.AtualizarFuncaoAsync(funcao);
                return Ok(funcao);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        
        [HttpDelete("apagar/{id}")] // É necessário receber o id na URL, porque quando se trata de apagar/delete, o APS.NET não converte um dado só do corpo, igual ocorre com uma atualização/Put, questão de bidding
                
        public async Task <IActionResult> DeleteFuncaoAsync(int id ) 
        {
            if(id <= 0)
                return BadRequest(ModelState);

            try 
            {                
                await _funcaoService.ApagarFuncaoAsync(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }





    }
}
