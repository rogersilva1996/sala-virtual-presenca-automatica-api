using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalaVirtual.Repositories;
using SalaVirtual.Util;
using SalaVItual.Services.Services;
using SalaVItual.Services.ViewModels;

namespace sala_virtual_presenca_automatica_api.Controllers
{
    [Route("api/[controller]")]
    public class PublicController : Controller
    {
        //private readonly IServiceTest _serviceTest;
        private readonly IRegisterRepository _createAcoutRepository;

        public PublicController(IRegisterRepository createAcoutRepository/*IServiceTest serviceTest*/)
        {
            _createAcoutRepository = createAcoutRepository;
            //_serviceTest = serviceTest;
        }

        [HttpGet]
        [Route("/test")]
        public IActionResult result()
        {
            UserViewModel userViewModel = new UserViewModel();

            

            return StatusCode(200, "teste api");
        }
    }
}
