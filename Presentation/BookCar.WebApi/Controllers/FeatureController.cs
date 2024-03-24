using BookCar.Application.Features.Mediator.Commands.FeatureCommands;
using BookCar.Application.Features.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookCar.WebApi.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IMediator _mediator;

        public FeatureController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            var values = await _mediator.Send(new GetFeatureQuery());
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("başarıyla eklendi");
        }
    }
}
