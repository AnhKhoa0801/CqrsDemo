using CqrsDemo.Core;
using Microsoft.EntityFrameworkCore;

namespace CqrsDemo.Infrastructure;

public class DatabaseContext:DbContext
{
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    public DatabaseContext(DbContextOptions options)
            : base(options)
    {
    }
}
