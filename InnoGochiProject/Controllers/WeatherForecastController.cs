using Microsoft.AspNetCore.Mvc;

namespace InnoGochiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DefaultController : ControllerBase
    {
        private readonly ILogger<DefaultController> _logger;

        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetSomeResult()
        {
            return Ok("Success");
        }
    }
}