
namespace Builder.FastFoodRestaurantSample;

public class MealBuilder
{
    public Meal PrepareVegMeal()
    {
        Meal meal = new ();
        meal.AddItem(new VegBurger());
        meal.AddItem(new Pepsi());
        return meal;
    }

    public Meal PrepareChickenMeal()
    {
        Meal meal = new();
        meal.AddItem(new ChickenBurger());
        meal.AddItem(new Coke());
        return meal;
    }
}
