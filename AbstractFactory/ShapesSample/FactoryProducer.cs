
namespace AbstractFactory.ShapesSample;

public class FactoryProducer
{
    public static IAbstractFactory GetFactory(bool rounded)
    {
        if (rounded)
        {
            return new RoundedShapeFactory();
        }
        else
        {
            return new ShapeFactory();
        }
    }
}
