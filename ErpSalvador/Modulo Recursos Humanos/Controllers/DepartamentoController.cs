namespace ErpSalvador.Controllers
{
    [ApiController]
    [Route("api/departamento")]

    public class DepartamentoController : ControllerBase
    {
        private readonly IDepartamentoService _departamentoService;

        public DepartamentoController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        [HttpPost("adicionar")]
        public async Task<IActionResult> PostDepartamentoAsync([FromBody] Departamento departamento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _departamentoService.CriarDepartamentoAsync(departamento);
                return StatusCode(StatusCodes.Status201Created);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("obter/{id}")]
        public async Task<IActionResult> GetDepartamentoAsync(int id)
        {

            try
            {
                Departamento departamentoFinal = await _departamentoService.LerDepartamentoAsync(id);

                return Ok(departamentoFinal);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpGet("obter-todos")]
        public async Task<ActionResult<IEnumerable<Departamento>>> GetAllDepartamentosAsync()
        {
            try
            {
                IEnumerable<Departamento> todosOsRegistros = await _departamentoService.LerTodosOsDepartamentosAsync();
                return Ok(todosOsRegistros);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        [HttpPut("atualizar")]
        public async Task <IActionResult> UpdateDepartamentoAsync([FromBody] Departamento departamento) 
        {
            if (departamento == null)
                return BadRequest(ModelState);

            try
            {
                await _departamentoService.AtualizarDepartamentoAsync(departamento);
                return Ok(departamento);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }

        
        [HttpDelete("apagar/{id}")] // É necessário receber o id na URL, porque quando se trata de apagar/delete, o APS.NET não converte um dado só do corpo, igual ocorre com uma atualização/Put, questão de bidding
                
        public async Task <IActionResult> DeleteDepartamentoAsync(int id ) 
        {
            if(id <= 0)
                return BadRequest(ModelState);

            try 
            {                
                await _departamentoService.ApagarDepartamentoAsync(id);
                return NoContent();
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex + "Ocorreu um erro interno");
            }
        }





    }
}
