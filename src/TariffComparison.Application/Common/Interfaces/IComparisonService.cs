using TariffComparison.Application.Services.Comparison;

namespace TariffComparison.Application.Common.Interfaces;

public interface IComparisonService
{
    ComparisonResult Compare(double consumption);
}