
namespace Strategy.Operations;

internal class OperationContext
{
    private readonly IOperationStrategy _strategy;

    public OperationContext(IOperationStrategy strategy) =>
        (_strategy) = (strategy);

    public int ExecuteStrategy(int number1, int number2)
    {
        return _strategy.DoOperation(number1, number2);
    }
}
