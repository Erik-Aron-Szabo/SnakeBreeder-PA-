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
            Console.WriteLine("(4) Display");
            Console.WriteLine("(6) back");
            Console.WriteLine("(7) Exit");
        }

        
        public List<WaterTerrarium> WaTerrariumSwitch(string choice, List<Snake> snakeList, string snakeFilename, List<WaterTerrarium> waTerList, string waterFilename)
        {
            SnakeMenu snakeMenu = new SnakeMenu();
            XML theXml = new XML();
            //maybe a WHILE here?
            while (true)
            {
                try
                {
                    if (choice == "create" || choice == "1")
                    {
                        AddTerToList(CreateWaTerrarium(waTerList), waTerList);
                        theXml.WaterTerWriteToXmlFile(waTerList, waterFilename);
                        break;

                    }
                    else if (choice == "destroy" || choice == "2")
                    {
                        Console.WriteLine("ID: ");
                        string id = Console.ReadLine();
                        DestroyTerrarium(waTerList, id);
                        theXml.WaterTerWriteToXmlFile(waTerList, waterFilename);
                        break;
                    }

                    else if (choice == "display" || choice == "4")
                    {
                        DisplayTerrarium(waTerList);
                        break;
                    }
                    else if (choice == "exit" )
                    {
                        System.Environment.Exit(1);
                    }
                    else if (choice == "back" || choice == "6")
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

        public void DestroyTerrarium(List<WaterTerrarium> waTerList, string id)
        {
            try
            {
                foreach (var ter in waTerList)
                {
                    if (ter.ID == id)
                    {
                        waTerList.Remove(ter);
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
            }
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

        public string DisplayTerrarium(List<WaterTerrarium> waTerList)
        {
            foreach (var ter in waTerList)
            {
                Console.WriteLine(ter.ToString());
                Console.WriteLine("----");
            }
            return "Done!";
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
