namespace ExamenApi.Controllers
{
    using ExamenApi.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _facturaService;
        public FacturaController(IFacturaService facturaService){
            _facturaService = facturaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            var cliente = await _facturaService.GetAllAsync();
            return Ok(cliente);
        }

        [HttpGet("fecha")]
        public async Task<IActionResult> GetByFecha([FromQuery] FacturaFechaDto facturaFechaDto)
        {            
            var cliente = await _facturaService.GetByFecha(facturaFechaDto);
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Factura factura)
        {
            var cliente = await _facturaService.AddAsync(factura);
            return Ok(cliente);
        }
    }
}