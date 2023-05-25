
namespace Decorator.ShapeSample;

internal class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(IShape decoratoredShape) : base(decoratoredShape){ }

    public override void Draw()
    {
        base._decoratedShape.Draw();
        SetRedBoarder(base._decoratedShape);
    }

    public void SetRedBoarder(IShape decoratoredShape)
    {
        Console.WriteLine("Set Boarder Color: Red.");
    }
}