using CqrsDemo.Application.Commands;
using CqrsDemo.Core;
using CqrsDemo.Infrastructure;
using MediatR;

namespace CqrsDemo.Application.Handlers;

public class CreateForecastCommandHandler : IRequestHandler<CreateWeatherForecastsCommand, WeatherForecast>
{
    private readonly DatabaseContext _databaseContext;
    public CreateForecastCommandHandler(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task<WeatherForecast> Handle(CreateWeatherForecastsCommand request, CancellationToken cancellationToken)
    {
        _databaseContext.WeatherForecasts.Add(request.NewForecast);
        await _databaseContext.SaveChangesAsync();
        return request.NewForecast;
    }
}
