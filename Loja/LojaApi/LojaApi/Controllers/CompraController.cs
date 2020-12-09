using LojaApi.Interfaces;
using LojaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LojaApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {
        private readonly ICompraService _compraService;

        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        }

        [HttpPost]
        public async Task<IActionResult> Realizar([FromBody] CompraRequest compraRequest)
        {
            var result = await _compraService.Efetivar(compraRequest);

            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }
    }
}