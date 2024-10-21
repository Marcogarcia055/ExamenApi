namespace ExamenApi.Controllers
{
    using ExamenApi.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService){
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            var cliente = await _clienteService.GetAllAsync();
            return Ok(cliente);
        }
    }
}