using TariffComparison.Application.Common.Exceptions;
using TariffComparison.Application.Common.Interfaces;
using TariffComparison.Application.Services.Comparison;

namespace TariffComparison.Application.Tests.Services;

public class ComparisonServiceTests
{
    private IComparisonService service;

    [SetUp]
    public void SetUp()
    {
        service = new ComparisonService();
    }

    [Test]
    public void ShouldReturnTariffListAsResultIncludingBothProduct()
    {
        //arrange

        //act
        var result = service.Compare(CONSUMPTION);

        //assert
        result.Should().BeAssignableTo<ComparisonResult>();
        result.tariffList.Should().HaveCount(2);
        result.tariffList.First().Should().BeAssignableTo<TariffResult>();
    }

    [Test]
    public void ShouldReturnInvalidConsumptionException_WhenInputIsInvalid()
    {
        //arrange

        //act
        var result = () => service.Compare(INVALID_CONSUMPTION);

        //assert
        result.Should().Throw<InvalidConsumptionException>();
    }

    private const double CONSUMPTION = 4000;
    private const double INVALID_CONSUMPTION = 0;
}
