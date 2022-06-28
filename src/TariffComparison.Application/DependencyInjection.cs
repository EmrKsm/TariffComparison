using Microsoft.Extensions.DependencyInjection;
using TariffComparison.Application.Common.Interfaces;
using TariffComparison.Application.Services.Comparison;

namespace TariffComparison.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IComparisonService, ComparisonService>();

        return services;
    }
}