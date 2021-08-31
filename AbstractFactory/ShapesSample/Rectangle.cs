using System;

namespace AbstractFactory.ShapesSample
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("You are a Rectangle, let's Draw you.");
        }
    }
}
