
using System;
using FactoryMethod.ShapesSample;

#region Shape demo section
// Ask for circle
IShape circle = ShapeFactory.GetShape(ShapeTypes.Circle);
circle.Draw();

// Ask for square
IShape square = ShapeFactory.GetShape(ShapeTypes.Square);
square.Draw();

// Ask for rectangle
IShape rectangle = ShapeFactory.GetShape(ShapeTypes.Rectangle);
rectangle.Draw();
#endregion

Console.WriteLine("Done!");
