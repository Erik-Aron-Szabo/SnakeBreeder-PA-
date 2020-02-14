using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class FoodStorage
    {
        public Dictionary<string, int> FoodBox = new Dictionary<string, int>();
        
        // adds food to a FoodStore (where you can choose what kind of food to feed your snakes)
        public void DisplayFoodStorage()
        {
            // for, print out every key-value-pair
        }

        public void AddToFoodStorage(string name, int howmany)
        {
            FoodBox.Add(name, howmany);
        }
    }
}
