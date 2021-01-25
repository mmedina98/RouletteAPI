using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouletteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouletteController : ControllerBase
    {

        public RouletteController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return null;
        }
    }
}
