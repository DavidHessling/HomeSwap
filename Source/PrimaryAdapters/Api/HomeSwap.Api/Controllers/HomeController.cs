using System.Collections.Generic;
using System.Threading.Tasks;
using HomeSwap.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.Api.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        public async Task<IActionResult> GetHomesAsync()
        {
            return Ok(new List<HomeDto>());
        }
    }
}
