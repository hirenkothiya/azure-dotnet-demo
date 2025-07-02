using Microsoft.AspNetCore.Mvc;

namespace SampleDotNetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Hello from Azure .NET App!");
    }
}
