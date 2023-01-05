using CqrsDemo.Application.Commands;
using CqrsDemo.Application.Queries;
using CqrsDemo.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsDemo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly IMediator _mediator;
    public WeatherForecastController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllForecastsQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] WeatherForecast weatherForecast)
    {
        var command = new CreateWeatherForecastsCommand
        {
            NewForecast = weatherForecast
        };
        var result = await _mediator.Send(command);

        return Ok(result);
    }
}