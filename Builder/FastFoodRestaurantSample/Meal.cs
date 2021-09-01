using System;
using System.Collections.Generic;

namespace Builder.FastFoodRestaurantSample
{
    public class Meal
    {
        private List<IItem> items = new ();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach(var item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"The items: {item.Name()}, Packing: {item.Packing().Pack()} and Price: {item.Price()}");
            }
        }
    }
}
