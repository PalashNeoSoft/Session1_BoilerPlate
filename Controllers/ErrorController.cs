using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Session1_BoilerPlate.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        [HttpGet]
        public IActionResult MyException()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error;



            return StatusCode(500, "Error in request");
        }

    }
}

