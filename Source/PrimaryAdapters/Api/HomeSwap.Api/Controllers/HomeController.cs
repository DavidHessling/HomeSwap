using System.Threading.Tasks;
using HomeSwap.Api.Dtos;
using HomeSwap.Application.PrimaryPorts.Queries.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HomeSwap.Api.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IGetHomesQuery _query;

        public HomeController(IMediator mediator, IGetHomesQuery query)
        {
            _mediator = mediator;
            _query = query;
        }

        public async Task<IActionResult> GetHomesAsync()
        {
            var homes = await _mediator.Send(_query);
            return Ok(homes);
        }
    }
}
