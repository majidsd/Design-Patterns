
namespace FactoryMethod.ShapesSample;

public class ShapeFactory
{
    // This method return object based on the type that you provide
    public static IShape GetShape(ShapeTypes shapeType)
    {
        return shapeType switch
        {
            ShapeTypes.Circle => new Circle(),
            ShapeTypes.Square => new Square(),
            ShapeTypes.Rectangle => new Rectangle(),
            _ => null,
        };
    }
}
