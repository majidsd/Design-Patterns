
using System;
using Builder.FastFoodRestaurantSample;

#region Fast Food Restaurant Demo
MealBuilder mealBuilder = new();

Meal veg = mealBuilder.PrepareVegMeal();
Console.WriteLine("Veg Meal");
veg.ShowItems();
Console.WriteLine($"Total cost is: {veg.GetCost()}");

Meal chicken = mealBuilder.PrepareChickenMeal();
Console.WriteLine("Chicken Meal");
chicken.ShowItems();
Console.WriteLine($"Total cost is: {chicken.GetCost()}");
#endregion

Console.WriteLine("Done!");
