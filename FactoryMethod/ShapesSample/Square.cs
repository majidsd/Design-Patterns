using System;

namespace FactoryMethod.ShapesSample
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("You are a Square, let's Draw you");
        }
    }
}
