
namespace AbstractFactory.ShapesSample
{
    public class ShapeFactory : IAbstractFactory
    {
        // This method return object based on the type that you provide
        public IShape GetShape(ShapeTypes shapeType)
        {
            return shapeType switch
            {
                ShapeTypes.Square => new Square(),
                ShapeTypes.Rectangle => new Rectangle(),
                _ => null,
            };
        }
    }
}
