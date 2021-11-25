using System;

namespace Observer.NumberSystemSample
{
    public class OctalObserver : IObserver
    {
        private readonly Subject subject;
        private const byte OCTAL_BASE = 8;
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Octal is: { Convert.ToString(subject.GetState(), OCTAL_BASE)}");
        }
    }
}
