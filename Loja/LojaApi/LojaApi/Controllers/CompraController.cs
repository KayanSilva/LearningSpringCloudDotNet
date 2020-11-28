using LojaApi.Interfaces;
using LojaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class CompraController : Controller
    {
        private readonly ICompraService _compraService;

        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        }

        [HttpPost]
        public void Realizar([FromBody] CompraRequest compraRequest)
        {

        }
    }
}
