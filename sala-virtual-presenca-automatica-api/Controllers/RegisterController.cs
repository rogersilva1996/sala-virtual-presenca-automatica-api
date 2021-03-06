﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpPost("signIn")]
        public IActionResult Register([FromBody] UserViewModel user)
        {
            try
            {
                if (_registerService.Register(user))
                {
                    return StatusCode(200, "Registro realizado com sucesso");
                }
                else
                {
                    return StatusCode(200, "Usuario ja cadastrado");
                }
                
            }
            catch(Exception ex)
            {
                return BadRequest("Erro ao efetuar cadastro");
                throw ex;
            }
            

            
        }
    }
}
