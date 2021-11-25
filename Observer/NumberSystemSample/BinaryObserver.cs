using System;

namespace Observer.NumberSystemSample
{
    public class BinaryObserver : IObserver
    {
        private readonly Subject subject;
        private const byte BINARY_BASE = 2;
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Binary is: { Convert.ToString(subject.GetState(), BINARY_BASE)}");
        }
    }
}
