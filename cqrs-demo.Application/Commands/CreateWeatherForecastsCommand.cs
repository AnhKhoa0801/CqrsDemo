using CqrsDemo.Core;
using MediatR;

namespace CqrsDemo.Application.Commands;

public class CreateWeatherForecastsCommand : IRequest<WeatherForecast>
{
    public WeatherForecast NewForecast { get; set; }
}
