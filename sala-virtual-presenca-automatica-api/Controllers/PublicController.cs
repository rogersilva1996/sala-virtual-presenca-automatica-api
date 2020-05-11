using Microsoft.AspNetCore.Mvc;

namespace sala_virtual_presenca_automatica_api.Controllers
{
    [Route("api/")]
    public class PublicController : Controller
    {
        //private readonly IServiceTest _serviceTest;

        public PublicController(/*IServiceTest serviceTest*/)
        {
            //_serviceTest = serviceTest;
        }

        //// GET api/values/5
        [HttpGet("test")]
        public IActionResult Get()
        {

            return StatusCode(200, "test");

        }


    }
}
