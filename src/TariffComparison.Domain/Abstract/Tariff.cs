using TariffComparison.Domain.Enums;

namespace TariffComparison.Domain.Abstract;

public abstract class Tariff
{
    protected double _consumption;
    public abstract string Name { get; }
    public abstract TariffTypes Type { get; }
    public abstract double CostPerUnit { get; }
    public abstract double BaseCost { get; }
    public abstract double AnnualCost { get; }
}
