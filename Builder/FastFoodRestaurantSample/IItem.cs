
namespace Builder.FastFoodRestaurantSample
{
    public interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }
}
