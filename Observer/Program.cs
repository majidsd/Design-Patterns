
using System;
using Observer.NumberSystemSample;


#region Number System demo section
int firstChangeValue = 20;
int secondChangeValue = 18;
Subject subject = new();

new BinaryObserver(subject);
new OctalObserver(subject);
new HexadecimalObserver(subject);

Console.WriteLine($"First chaning for the state to {firstChangeValue}");
subject.SetState(firstChangeValue);
Console.WriteLine($"Second chaning for the state to {secondChangeValue}");
subject.SetState(secondChangeValue);
#endregion

Console.WriteLine("Done!");
