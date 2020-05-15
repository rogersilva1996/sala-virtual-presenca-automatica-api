using Microsoft.AspNetCore.Mvc;
using SalaVItual.Services.Services;
using SalaVItual.Services.ViewModels;

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
            if (_recoverPasswordService.Recover(user.email))
            {
                return StatusCode(200, "OK");
            }

            return StatusCode(Response.StatusCode);
            
        }

    }
}
