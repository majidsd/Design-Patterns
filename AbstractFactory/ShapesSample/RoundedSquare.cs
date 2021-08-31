using System;

namespace AbstractFactory.ShapesSample
{
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("You are a Rounded Square, let's Draw you");
        }
    }
}
