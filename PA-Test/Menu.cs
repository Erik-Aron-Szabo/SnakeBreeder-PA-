using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class Menu
    {
        public XML theXml = new XML();


        public void DisplayMainMenu()
        {

            // displays menu (create snake, destroy snake, feed snake, terrarium etc.)
            Console.WriteLine("Main Menu");
            Console.WriteLine("(1) Snake");
            Console.WriteLine("(2) Terrarium");
            Console.WriteLine("(3) Food");
            Console.WriteLine("(4) Exit");
            

        }

        public string InputHandler(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        public List<Snake> CreateSnakeList()
        {
            List<Snake> snakeList2 = new List<Snake>();
            return snakeList2;
        }


        //delegate void snakecommand();
        // commands[choice]();

        //dictionary<string, snakecommand> commands = new dictionary<string, snakecommand>();

        public bool Switch(string choice, List<Snake> snakeList, string filename)
        {
            SnakeMenu snakeMenu = new SnakeMenu();
            FoodMenu foodMenu = new FoodMenu();
            TerrariumMenu terrariumMenu = new TerrariumMenu();
            try
            {
                if (choice == "snake")
                {

                    snakeMenu.DisplaySnakeMenu();
                    string ui = Console.ReadLine();
                    theXml.WriteToXmlFile(snakeMenu.SnakeSwitch(ui, snakeList, filename));
                    return true;
                }
                else if (choice == "terrarium")
                {
                    terrariumMenu.DisplayTerrariumMenu();
                    string ui = Console.ReadLine();
                    terrariumMenu.TerrariumSwitch(ui);
                    return true;

                }
                else if (choice == "food")
                {
                    foodMenu.DisplayFoodMenu();
                    string ui = Console.ReadLine();
                    foodMenu.FoodSwitch(ui);
                    return true;

                }
                else if (choice == "exit")
                {

                    return false;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invlaid input!(3)");
            }
                    return true;


        }

        public Menu()
        {

        }
    }
}
