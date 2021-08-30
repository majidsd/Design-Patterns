using System;

namespace FactoryMethod.ShapesSample
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("You are a Circle, let's Draw you");
        }

    }
}
