
namespace Builder.FastFoodRestaurantSample
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 10.0f;
        }
    }
}
