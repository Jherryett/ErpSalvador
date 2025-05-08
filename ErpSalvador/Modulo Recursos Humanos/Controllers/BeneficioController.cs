
using Azure.Core;

namespace ErpSalvador.Controllers
{
    [ApiController]
    [Route("api/beneficios")]

    public class BeneficioController : ControllerBase
    {
        private readonly IBeneficioService _beneficioService;

        public BeneficioController(IBeneficioService beneficioService)
        {
            _beneficioService = beneficioService;
        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> AdicionarBeneficio([FromBody] Beneficio beneficio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _beneficioService.CriarBeneficio(beneficio);
                return StatusCode(StatusCodes.Status201Created);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("Obter")]
        public async Task<IActionResult> ObterBeneficio(int id)
        {

            try
            {
                Beneficio beneficioFinal = await _beneficioService.LerBeneficio(id);

                return Ok(beneficioFinal);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("ObterTodos")]
        public async Task<ActionResult<IEnumerable<Beneficio>>> LerTodosOsBeneficios()
        {
            try
            {
                IEnumerable<Beneficio> todosOsRegistros = await _beneficioService.LerTodosOsBeneficios();
                return Ok(todosOsRegistros);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpPut("Atualizar")]
        public async Task <IActionResult> AtualizarBeneficio([FromBody] Beneficio beneficio) 
        {
            if (beneficio == null)
                return BadRequest(ModelState);

            try
            {
                await _beneficioService.AtualizarBeneficio(beneficio);
                return Ok(beneficio);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        
        [HttpDelete("Apagar/{id}")] // É necessário receber o id na URL, porque quando se trata de apagar/delete, o APS.NET não converte um dado só do corpo, igual ocorre com uma atualização/Put, questão de bidding
                
        public async Task <IActionResult> ApagarBeneficio(int id ) 
        {
            if(id <= 0)
                return BadRequest(ModelState);

            try 
            {                
                await _beneficioService.ApagarBeneficio(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }





    }
}
