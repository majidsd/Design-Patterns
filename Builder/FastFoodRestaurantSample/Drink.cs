
namespace Builder.FastFoodRestaurantSample;

public abstract class Drink : IItem
{
    public abstract string Name();
    
    public IPacking Packing()
    {
        return new Bottle();
    }

    public abstract float Price();
}
