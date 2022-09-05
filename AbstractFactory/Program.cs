
using System;
using AbstractFactory.ShapesSample;

#region Shape Demo Section
// Ask for normal shape factory and then get normal shapes
bool rounded = false;
IAbstractFactory shapeFactory = FactoryProducer.GetFactory(rounded);

IShape square = shapeFactory.GetShape(ShapeTypes.Square);
square.Draw();

IShape rectangle = shapeFactory.GetShape(ShapeTypes.Rectangle);
rectangle.Draw();

// Ask for rounded shape factory and then get rounded shapes
rounded = true;
IAbstractFactory roundedShapeFactory = FactoryProducer.GetFactory(rounded);

IShape roundedSquare = roundedShapeFactory.GetShape(ShapeTypes.Square);
roundedSquare.Draw();

IShape roundedRectangle = roundedShapeFactory.GetShape(ShapeTypes.Rectangle);
roundedRectangle.Draw();
#endregion

Console.WriteLine("Done!");
