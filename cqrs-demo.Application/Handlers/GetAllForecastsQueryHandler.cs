using CqrsDemo.Application.Queries;
using CqrsDemo.Core;
using CqrsDemo.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CqrsDemo.Application.Handlers;

public class GetAllForecastsQueryHandler : IRequestHandler<GetAllForecastsQuery, List<WeatherForecast>>
{
    private readonly DatabaseContext _databaseContext;
    public GetAllForecastsQueryHandler(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task<List<WeatherForecast>> Handle(GetAllForecastsQuery request, CancellationToken cancellationToken)
    {
        return await _databaseContext.WeatherForecasts.ToListAsync();
    }
}
