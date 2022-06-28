using TariffComparison.Domain.Abstract;
using TariffComparison.Domain.Enums;

namespace TariffComparison.Domain.Entities;

public class BasicTariff : Tariff
{
    public BasicTariff(double consumption)
    {
        _consumption = consumption;
    }

    public override string Name => "basic electricity tariff";
    public override TariffTypes Type => TariffTypes.Basic;

    public override double CostPerUnit => 0.22;

    public override double BaseCost => 5 * 12;

    public override double AnnualCost => BaseCost + _consumption * CostPerUnit;
}