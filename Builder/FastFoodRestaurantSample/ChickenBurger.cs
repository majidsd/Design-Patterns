
namespace Builder.FastFoodRestaurantSample
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float Price()
        {
            return 12.5f;
        }
    }
}
