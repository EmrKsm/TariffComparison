namespace TariffComparison.Application.Services.Comparison;

public record ComparisonResult(IEnumerable<TariffResult> tariffList);