using Microsoft.AspNetCore.Mvc;
using Moq;
using TariffComparison.Api.Controller;
using TariffComparison.Application.Common.Interfaces;
using TariffComparison.Application.Services.Comparison;

namespace TariffComparison.Api.Tests.Controllers;

public class ComparisonControllerTests
{
    [Test]
    public void ShouldReturnTariffListAsJson()
    {
        //arrange
        Mock<IComparisonService> service = new Mock<IComparisonService>();

        service.Setup(x => x.Compare(CONSUMPTION)).Returns(RESULT);

        var controller = new ComparisonController(service.Object);

        //act
        var result = controller.Compare(CONSUMPTION);
        var okResult = result as OkObjectResult;

        //assert
        okResult.Should().NotBeNull();
        okResult.StatusCode.Should().Be(200);
        okResult.Value.Should().BeAssignableTo<ComparisonResult>();
    }

    private const double CONSUMPTION = 4000;
    private readonly static ComparisonResult RESULT = new(new List<TariffResult>());
}
