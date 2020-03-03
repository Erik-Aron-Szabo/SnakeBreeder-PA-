using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class LaTerrariumMenu //La = Land
    {
        Utility util = new Utility();


        public void LaTerrariumMenuDisplay()
        {
            Console.WriteLine("Land Terrarium Menu");
            Console.WriteLine("(1) Create (Terarium and adds it to the List)");
            Console.WriteLine("(2) Destroy (Terrarium)");
            Console.WriteLine("(3) Snakes Menu");
            Console.WriteLine("(4) Update");
            Console.WriteLine("(5) Display");
            Console.WriteLine("(6) Add snake to terrarium");
            Console.WriteLine("() Exit");
        }

        

        public List<LandTerrarium> LaTerrariumSwitch(string choice, List<Snake> snakeList, string snakeFilename, List<WaterTerrarium> waTerList, string waterFilename, List<LandTerrarium> lanTerList, string lanTerfilename)
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
                        AddTerToList(CreateLaTerrarium(lanTerList), lanTerList);
                        Console.WriteLine("Done");
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
                        DisplayTerrarium(lanTerList);
                    }
                    else if (choice == "3") //Snake Menu
                    {
                        snakeMenu.DisplaySnakeMenu();
                        string ui = Console.ReadLine();
                        theXml.WriteToXmlFile(snakeMenu.SnakeSwitch(ui, snakeList, waTerList, lanTerList, snakeFilename), snakeFilename);
                    }
                    else if (choice == "6")
                    {

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

            return lanTerList;
        }

        public void AddSnakeToTerrarium(string id, List<LandTerrarium> lanTerList, List<Snake> snakeList)
        {
            
            foreach (var ter in lanTerList)
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

        public void AddTerToList(LandTerrarium lanTer, List<LandTerrarium> lanTerList) //CHANGED LandTerrarium -> Terrarium
        {
            lanTerList.Add(lanTer);
        }

        public LandTerrarium CreateLaTerrarium(List<LandTerrarium> terList)
        {
            string id = util.IdGenerator();
            List<Snake> snakeList = new List<Snake>();
            LandTerrarium lanTer = new LandTerrarium(id, snakeList); //PROBLEM maybe change LandTerrarium to just Terrarium?
            return lanTer;
        }
        public void DisplayTerrarium(List<LandTerrarium> terList)
        {
            foreach (var ter in terList)
            {
                Console.WriteLine(ter.ToString());
                Console.WriteLine("----");
            }
        }
    }
}
