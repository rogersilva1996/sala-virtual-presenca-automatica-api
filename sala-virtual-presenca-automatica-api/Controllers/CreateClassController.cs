using Microsoft.AspNetCore.Mvc;
using SalaVItual.Services.Services;
using SalaVItual.Services.ViewModels;

namespace SalaVirtual.Api.Controllers
{
    [Route("api/sala/virtual/criar/")]
    public class CreateClassController : Controller
    {
        private ICreateClassService _createClassService;

        public CreateClassController(ICreateClassService createClassService)
        {
            _createClassService = createClassService;
        }

        [HttpPost("sala")]
        public IActionResult CreateClass([FromBody] CreateClassViewModel vm)
        {
            try
            {
                bool result = _createClassService.Create(vm);

                if (result)
                {
                    return StatusCode(200);
                }
                else
                {
                    return StatusCode(200, "Erro ao criar sala");
                }

            }
            catch
            {
                return BadRequest("erro");
            }
        }
    }
}
