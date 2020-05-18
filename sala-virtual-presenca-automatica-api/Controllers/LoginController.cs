using Microsoft.AspNetCore.Mvc;
using SalaVItual.Services.Services;
using SalaVItual.Services.ViewModels;
using System;

namespace SalaVirtual.Api.Controllers
{

    [Route("api/sala/virtual/acesso/")]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody]UserViewModel user)
        {
            try
            {
                if (_loginService.login(user))
                {
                    return StatusCode(200);
                }
                else
                {
                    return StatusCode(200, "dados cadastrais incorretos");
                }

            }
            catch(Exception ex)
            {
                return BadRequest("erro ao efetuar login" + ex.Message);
            }
           
        }

    }
}
