using DemoDevOpsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoDevOpsAPI.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class DemoController : Controller
    {
        [HttpPost]
        public IActionResult ValidatorsTest(RegisterDTO registerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
