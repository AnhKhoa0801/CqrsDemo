using CqrsDemo.Core;
using MediatR;

namespace CqrsDemo.Application.Queries;

public class GetAllForecastsQuery:IRequest<List<WeatherForecast>>
{
}
