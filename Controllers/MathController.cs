using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SithecExamErickBernal.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public IActionResult Calculate([FromHeader] int x, [FromHeader] int y, [FromHeader] string operacion)
        {
            int result = 0;

            switch (operacion.ToLower())
            {
                case "suma":
                    result = x + y;
                    break;
                case "resta":
                    result = x - y;
                    break;
                case "multiplicacion":
                    result = x * y;
                    break;
                case "division":
                    result = x / y;
                    break;
                default:
                    return BadRequest("Error api.");
            }

            return Ok(result);
        }
    }
}