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
            Console.WriteLine("Main Menu");
            Console.WriteLine("(1) Water Terrarium Menu");
            Console.WriteLine("(2) Land Terrarium Menu");
            Console.WriteLine("(3) Snakes Menu");
            Console.WriteLine("(4) Food Menu");
            Console.WriteLine("() Back");
            Console.WriteLine("() Exit");
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


        public bool Switch(string choice, List<Snake> snakeList, List<LandTerrarium> lanTerList, List<WaterTerrarium> waTerList, string snakeFilename, string terFilename, string waterFilename) //MISSING waTer
        {
            SnakeMenu snakeMenu = new SnakeMenu();
            FoodMenu foodMenu = new FoodMenu();
            WaTerrariumMenu waTerrariumMenu = new WaTerrariumMenu();
            LaTerrariumMenu laTerrariumMenu = new LaTerrariumMenu();
            try
            {
                if (choice == "snake")
                {

                    snakeMenu.DisplaySnakeMenu();
                    string ui = Console.ReadLine();
                    theXml.WriteToXmlFile(snakeMenu.SnakeSwitch(ui, snakeList,  waTerList, lanTerList, snakeFilename), snakeFilename);
                    return true;
                }
                else if (choice == "2")
                {
                    laTerrariumMenu.LaTerrariumMenuDisplay();
                    string ui = Console.ReadLine();
                    theXml.LandTerWriteToXmlFile(laTerrariumMenu.LaTerrariumSwitch(ui, snakeList, snakeFilename, waTerList, waterFilename ,lanTerList, terFilename), terFilename);
                    return true;

                }
                else if (choice == "1")
                {
                    waTerrariumMenu.WaTerrariumMenuDisplay();
                    string ui = Console.ReadLine();
                    theXml.WaterTerWriteToXmlFile(waTerrariumMenu.WaTerrariumSwitch(ui, snakeList, snakeFilename, waTerList, waterFilename, lanTerList, terFilename), terFilename);
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
