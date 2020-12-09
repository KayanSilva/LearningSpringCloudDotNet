using FornecedorApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FornecedorApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        private readonly InfoService _infoService;

        public InfoController(InfoService infoService)
        {
            _infoService = infoService;
        }

        [HttpGet("{estado}")]
        public async Task<IActionResult> PorEstado([FromRoute] string estado)
        {
            var result = _infoService.PorEstado(estado);
            return new ObjectResult(result) { StatusCode = StatusCodes.Status200OK };
        }
    }
}