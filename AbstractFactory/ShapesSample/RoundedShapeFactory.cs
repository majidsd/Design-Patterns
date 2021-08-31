
namespace AbstractFactory.ShapesSample
{
    public class RoundedShapeFactory : IAbstractFactory
    {
        // This method return object based on the type that you provide
        public IShape GetShape(ShapeTypes shapeType)
        {
            return shapeType switch
            {
                ShapeTypes.Square => new RoundedSquare(),
                ShapeTypes.Rectangle => new RoundedRectangle(),
                _ => null,
            };
        }
    }
}
