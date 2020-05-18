using Microsoft.AspNetCore.Mvc;
using SalaVirtual.Repositories;
using SalaVItual.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaVirtual.Api.Controllers
{
    [Route("api/sala/virtual/entrar/")]
    public class SingInClassController : Controller
    {
        private readonly ISingInClassService _singInClassService;

        public SingInClassController(ISingInClassService singInClassService)
        {
            _singInClassService = singInClassService;
        }

        [HttpGet("sala")]
        public IActionResult SingInClass(string email, string codigoSala, string numeroIdentificacao)
        {
            try
            {
                bool result = _singInClassService.Connect(email, codigoSala, numeroIdentificacao);

                if (result)
                {
                    return StatusCode(200);
                }
                else
                {
                    return StatusCode(200, "sala nao encontrada");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }         
        }
    }
}
