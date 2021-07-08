using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WhoWins.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightersController : ControllerBase
    {
        public FightersController(ILogger<FightersController> logger)
        {
        }

        [HttpGet]
        public IEnumerable<int> GetAllFighters()
        {
            throw new NotImplementedException();
        }
    }
}
