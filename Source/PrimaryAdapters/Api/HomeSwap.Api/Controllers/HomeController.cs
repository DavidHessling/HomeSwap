using System.Threading.Tasks;
using HomeSwap.UseCases.Abstractions.Home.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.Api.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IGetHomesQuery _getHomesQuery;

        public HomeController(IMediator mediator, IGetHomesQuery getHomesQuery)
        {
            _mediator = mediator;
            _getHomesQuery = getHomesQuery;
        }

        public async Task<IActionResult> GetHomesAsync()
        {
            var homes = await _mediator.Send(_getHomesQuery);
            return Ok(homes);
        }
    }
}
