using Microsoft.AspNetCore.Mvc;
using SalaVItual.Services.Services;
using SalaVItual.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaVirtual.Api.Controllers
{
    [Route("api/sala/virtual/registro/")]
    public class RegisterController : Controller
    {
        private readonly IRegisterService _registerService;

        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost("SignIn")]
        public IActionResult Register([FromBody] UserViewModel user)
        {
            _registerService.Register(user);

            return StatusCode(200);
        }
    }
}
