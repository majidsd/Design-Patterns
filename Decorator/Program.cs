using Decorator.ShapeSample;

#region Shape Decorator Dem
IShape circle = new Circle();
IShape redCircle = new RedShapeDecorator(circle);
circle.Draw();
redCircle.Draw();

IShape rectangle = new Rectangle();
IShape redRectangle = new RedShapeDecorator(rectangle);
rectangle.Draw();
redRectangle.Draw();
#endregion

Console.WriteLine("Done!");
