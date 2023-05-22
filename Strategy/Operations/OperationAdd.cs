
namespace Strategy.Operations;

internal class OperationAdd : IOperationStrategy
{
    public int DoOperation(int number1, int number2)
    {
        return number1 + number2;
    }
}
