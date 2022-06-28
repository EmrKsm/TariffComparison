using TariffComparison.Domain.Abstract;
using TariffComparison.Domain.Enums;

namespace TariffComparison.Domain.Entities;

public class PackagedTariff : Tariff
{
    public PackagedTariff(double consumption)
    {
        _consumption = consumption;
    }

    public override string Name => "Packaged tariff";
    public override TariffTypes Type => TariffTypes.Packaged;

    public override double CostPerUnit => 0.30;

    public override double BaseCost => 800;

    public static double TariffLimit => 4000;

    public override double AnnualCost
        => _consumption <= TariffLimit ? BaseCost : BaseCost + (_consumption - TariffLimit) * CostPerUnit;
}
