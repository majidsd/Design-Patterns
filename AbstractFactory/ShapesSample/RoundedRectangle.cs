
using System;

namespace AbstractFactory.ShapesSample;

public class RoundedRectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("You are a Rounded Rectangle, let's Draw you.");
    }
}
