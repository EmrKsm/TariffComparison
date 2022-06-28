using TariffComparison.Application.Common.Factories;
using TariffComparison.Domain.Enums;

namespace TariffComparison.Application.Tests.Common.Factories;

public class TariffFactoryTests
{
    [Test]
    public void ShouldCreateBasicTariff_WhenBasicTypeGiven()
    {
        //arrange
        var type = TariffTypes.Basic;

        //act
        var tariff = TariffFactory.GetTariff(type, CONSUMPTION);

        //assert
        tariff.Name.Should().BeEquivalentTo(BASIC_TARIFF_NAME);
        tariff.Type.Should().Be(TariffTypes.Basic);
    }

    [Test]
    public void ShouldCreatePackagedTariff_WhenPackagedTypeGiven()
    {
        //arrange
        var type = TariffTypes.Packaged;

        //act
        var tariff = TariffFactory.GetTariff(type, CONSUMPTION);

        //assert
        tariff.Name.Should().BeEquivalentTo(PACKAGED_TARIFF_NAME);
        tariff.Type.Should().Be(TariffTypes.Packaged);
    }

    private const double CONSUMPTION = 4000;
    private const string BASIC_TARIFF_NAME = "basic electricity tariff";
    private const string PACKAGED_TARIFF_NAME = "Packaged tariff";
}
