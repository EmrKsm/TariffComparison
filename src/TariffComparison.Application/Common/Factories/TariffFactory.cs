using TariffComparison.Domain.Abstract;
using TariffComparison.Domain.Entities;
using TariffComparison.Domain.Enums;

namespace TariffComparison.Application.Common.Factories;

public class TariffFactory
{
    public static Tariff GetTariff(TariffTypes type, double consumption) => type switch
    {
        TariffTypes.Basic => new BasicTariff(consumption),
        TariffTypes.Packaged => new PackagedTariff(consumption),
        _ => throw new ArgumentException($"Not expected type value: {type}", nameof(type)),
    };
}
