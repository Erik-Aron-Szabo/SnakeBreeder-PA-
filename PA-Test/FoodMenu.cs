using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class FoodMenu : Menu
    {
        public void DisplayFoodMenu()
        {
            Console.WriteLine("Food Menu");
            Console.WriteLine("(1) Feed");
            Console.WriteLine("(2) Add (to FoodBox)");
            Console.WriteLine("(3) Back");
            Console.WriteLine("(4) Exit");
        }

        public void FoodSwitch(string choice)
        {
            try
            {
                if (choice == "feed")
                {
                    //
                }
                else if (choice == "add")
                {
                    Console.WriteLine("Name of food: ");
                    string uiName = Console.ReadLine();

                    Console.WriteLine("How many would you like to add to FoodBox: ");
                    int uiHowmany = Int32.Parse(Console.ReadLine());

                    FoodStorage FoodKamra = new FoodStorage();
                    FoodKamra.AddToFoodStorage(uiName, uiHowmany);

                }
                else if (choice == "exit")
                {
                    System.Environment.Exit(1);
                }
                else if (choice == "back")
                {
                    // go back to MainMenu
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!");
            }
                
            
        }
    }
}


