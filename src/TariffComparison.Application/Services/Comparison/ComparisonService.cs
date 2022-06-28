using TariffComparison.Application.Common.Exceptions;
using TariffComparison.Application.Common.Factories;
using TariffComparison.Application.Common.Interfaces;
using TariffComparison.Domain.Enums;

namespace TariffComparison.Application.Services.Comparison;

public class ComparisonService : IComparisonService
{
    public ComparisonResult Compare(double consumption)
        => consumption <= 0 ? throw new InvalidConsumptionException() : new(CreateTariffList(consumption));

    private IEnumerable<TariffResult> CreateTariffList(double consumption)
    {
        var basicTariff = TariffFactory.GetTariff(TariffTypes.Basic, consumption);
        var packagedTariff = TariffFactory.GetTariff(TariffTypes.Packaged, consumption);

        List<TariffResult> result = new()
        {
            new TariffResult(basicTariff.Name, $"{basicTariff.AnnualCost} (€/year)"),
            new TariffResult(packagedTariff.Name, $"{packagedTariff.AnnualCost} (€/year)")
        };

        return result.OrderBy(r => r.annualCost);
    }
}