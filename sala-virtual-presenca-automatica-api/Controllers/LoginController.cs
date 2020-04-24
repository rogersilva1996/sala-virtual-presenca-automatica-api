using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaVirtual.Api.Controllers
{

    [Route("api/sala/virtual/acesso/")]
    public class LoginController : Controller
    {
        [HttpGet("login")]
        public void Login()
        {
            //return StatusCode(200);
        }

    }
}
