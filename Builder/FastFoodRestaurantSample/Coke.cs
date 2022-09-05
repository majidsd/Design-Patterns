
namespace Builder.FastFoodRestaurantSample;

public class Coke : Drink
{
    public override string Name()
    {
        return "Coke";
    }

    public override float Price()
    {
        return 1.8f;
    }
}
