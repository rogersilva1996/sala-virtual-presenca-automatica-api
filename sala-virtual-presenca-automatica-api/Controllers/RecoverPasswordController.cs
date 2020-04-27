using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalaVItual.Services.Services;
using SalaVItual.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaVirtual.Api.Controllers
{
    [Route("api/sala/virtual/recuperacao/senha/")]
    public class RecoverPasswordController : Controller
    {
        private readonly IRecoverPasswordService _recoverPasswordService;

        public RecoverPasswordController(IRecoverPasswordService recoverPasswordService)
        {
            _recoverPasswordService = recoverPasswordService;
        }


        [HttpPost("recuperar")]
        public IActionResult Recover([FromBody]UserViewModel user)
        {


            return StatusCode(200);
        }

    }
}
