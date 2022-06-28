namespace TariffComparison.Application.Common.Exceptions;

public class InvalidConsumptionException : Exception
{
    private const string MESSAGE = "Entered consumption data is invalid, please try another.";
    public InvalidConsumptionException()
        : base(MESSAGE)
    {
    }
}
