using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class WaTerrariumMenu // Wa = Water
    {
        Utility util = new Utility();

        public void WaTerrariumMenuDisplay()
        {
            Console.WriteLine("Water Terrarium Menu");
            Console.WriteLine("(1) Create (Terrarium)");
            Console.WriteLine("(2) Destroy (Terrarium)");
            Console.WriteLine("(3) Snakes Menu");
            Console.WriteLine("(4) Update");
            Console.WriteLine("(5) Display");
            Console.WriteLine("() Exit");
        }

        
        public List<WaterTerrarium> WaTerrariumSwitch(string choice, List<Snake> snakeList, string snakeFilename, List<WaterTerrarium> waTerList, string waterFilename, List<LandTerrarium> lanTerList, string lanTerfilename)
        {
            SnakeMenu snakeMenu = new SnakeMenu();
            XML theXml = new XML();
            //maybe a WHILE here?
            while (true)
            {
                try
                {
                    if (choice == "create")
                    {
                        AddTerToList(CreateWaTerrarium(waTerList), waTerList);
                    }
                    else if (choice == "destroy")
                    {
                        Console.WriteLine("Name: ");
                        string uiName = Console.ReadLine();
                        Console.WriteLine("Type: ");
                        string uiType = Console.ReadLine();
                        //theXml.WriteToXmlFile(DeleteSnake(uiName, uiType, snakeList), filename);
                        Console.WriteLine("Done!");
                    }

                    else if (choice == "display")
                    {
                        DisplayTerrarium(waTerList);
                    }
                    else if (choice == "add")
                    {
                        // add snake into terrarium
                    }
                    else if (choice == "exit")
                    {
                        System.Environment.Exit(1);
                    }
                    else if (choice == "back")
                    {
                        break;
                        // go back to MainMenu
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                }
            }
           

            return waTerList;
        }

        public void AddSnakeToTerrarium(string id, List<WaterTerrarium> waTerList, List<Snake> snakeList)
        {

            foreach (var ter in waTerList)
            {
                if (ter.ID == id)
                {
                    foreach (var snake in snakeList)
                    {
                        Console.WriteLine("Name of the snake:");
                        string name = Console.ReadLine();
                        if (name == snake.Name)
                        {
                            ter.AddSnake(snake);
                        }
                    }

                }
            }
        }

        public void AddTerToList(WaterTerrarium waTer, List<WaterTerrarium> waTerList) //CHANGED LandTerrarium -> Terrarium
        {
            waTerList.Add(waTer);
        }

        public void DisplayTerrarium(List<WaterTerrarium> waTerList)
        {
            foreach (var ter in waTerList)
            {
                Console.WriteLine(ter.ToString());
                Console.WriteLine("----");
            }
        }

        public WaterTerrarium CreateWaTerrarium(List<WaterTerrarium> waTerList)
        {
            string id = util.IdGenerator();
            List<Snake> snakeList = new List<Snake>();
            WaterTerrarium lanTer = new WaterTerrarium(id, snakeList); //PROBLEM maybe change LandTerrarium to just Terrarium?
            return lanTer;
        }
    }
}
