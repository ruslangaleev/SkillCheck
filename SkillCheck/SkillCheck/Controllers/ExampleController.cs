using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SkillCheck.Controllers
{
    [Route("api/example")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("test");
        }
    }
}
