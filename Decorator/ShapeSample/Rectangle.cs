﻿
namespace Decorator.ShapeSample;

internal class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Shape: Rectangle");
    }
}