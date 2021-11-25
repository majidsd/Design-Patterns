using Observer.NumberSystemSample;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Number System demo section
            int firstChnageValue = 20;
            int secondChnageValue = 18;
            Subject subject = new ();

            new BinaryObserver(subject);
            new OctalObserver(subject);
            new HexadecimalObserver(subject);

            Console.WriteLine($"First chaning for the state to {firstChnageValue}");
            subject.SetState(firstChnageValue);
            Console.WriteLine($"Second chaning for the state to {secondChnageValue}");
            subject.SetState(secondChnageValue);
            #endregion

            Console.WriteLine("Done!");
        }
    }
}
