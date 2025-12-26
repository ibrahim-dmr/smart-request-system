using Microsoft.AspNetCore.Mvc;

namespace SmartRequestSystem.API.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult HandleError()
        {
            return Problem("Unexpected error occurred.");
        }
    }
}
