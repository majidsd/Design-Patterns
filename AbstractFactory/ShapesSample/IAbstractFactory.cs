
namespace AbstractFactory.ShapesSample;

public interface IAbstractFactory
{
    IShape GetShape(ShapeTypes shapeType);
}
