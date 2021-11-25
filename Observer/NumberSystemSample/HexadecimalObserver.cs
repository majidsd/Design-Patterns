using System;

namespace Observer.NumberSystemSample
{
    public class HexadecimalObserver : IObserver
    {
        private readonly Subject subject;
        private const byte HEXADECIMAL_BASE = 16;
        public HexadecimalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Hexadecimal is: { Convert.ToString(subject.GetState(), HEXADECIMAL_BASE)}");
        }
    }
}
