
using Strategy.OperationsSample;

#region Operations Strategy Demo
OperationContext context1 = new (new OperationAdd());
Console.WriteLine(context1.ExecuteStrategy(5,5));

OperationContext context2 = new (new OperationSubtract());
Console.WriteLine(context2.ExecuteStrategy(5, 5));

OperationContext context3 = new (new OperationMultiple());
Console.WriteLine(context3.ExecuteStrategy(5, 5));
#endregion

Console.WriteLine("Done!");
