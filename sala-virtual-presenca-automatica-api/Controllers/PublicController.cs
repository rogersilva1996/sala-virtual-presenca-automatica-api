using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalaVirtual.Repositories;
using SalaVItual.Services.Services;
using SalaVItual.Services.ViewModels;

namespace sala_virtual_presenca_automatica_api.Controllers
{
    [Route("api/[controller]")]
    public class PublicController : Controller
    {
        //private readonly IServiceTest _serviceTest;
        private readonly ICreateAcoutRepository _createAcoutRepository;

        public PublicController(ICreateAcoutRepository createAcoutRepository/*IServiceTest serviceTest*/)
        {
            _createAcoutRepository = createAcoutRepository;
            //_serviceTest = serviceTest;
        }

        [HttpGet]
        [Route("/test")]
        public IActionResult result()
        {
            UserViewModel userViewModel = new UserViewModel();

            _createAcoutRepository.CreateAcout("rotest", "test@hotmail.com", "roger123");

            return StatusCode(200, userViewModel);
        }

            

        //// GET api/values/5
        //[HttpGet("test")]
        //public IActionResult Get(int value1, int value2)
        //{

        //    return StatusCode(200, _serviceTest.calc(value1, value2));

        //}


    }
}
