using TariffComparison.Application.Common.Exceptions;

namespace TariffComparison.Application.Tests.Common.Exceptions;

public class InvalidConsumptionExceptionTests
{
    [Test]
    public void DefaultConstructorCreatesAnExceptionWithDefaultMessage()
    {
        // arrange
        var exception = new InvalidConsumptionException();

        // act

        // assert
        exception.Message.Should().BeEquivalentTo(MESSAGE);
    }

    private const string MESSAGE = "Entered consumption data is invalid, please try another.";
}
