using Microsoft.AspNetCore.Mvc;
using SalaVItual.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaVirtual.Api.Controllers
{
    [Route("api/sala/virtual/adicionar/")]
    public class PresencaController : Controller
    {
        private readonly IPresencaService _presencaService;

        public PresencaController(IPresencaService presencaService)
        {
            _presencaService = presencaService;
        }

        [HttpGet("presenca")]
        public IActionResult presenca(string codigoSala)
        {
            try
            {
                _presencaService.AdicionarPresenca(codigoSala);
                return StatusCode(200);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
