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
            
            Console.WriteLine("(4) Display");
            Console.WriteLine("(5) back");
            Console.WriteLine("() Exit");
        }

        

        public List<LandTerrarium> LaTerrariumSwitch(string choice, List<Snake> snakeList, string snakeFilename, List<LandTerrarium> lanTerList, string lanTerfilename)
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
                        AddTerToList(CreateLaTerrarium(lanTerList), lanTerList);
                        Console.WriteLine("Done");
                        break;
                    }
                    else if (choice == "destroy" || choice == "2")
                    {
                        Console.WriteLine("ID: ");
                        string id = Console.ReadLine();
                        DestroyTerrarium(lanTerList, id);
                        break;
                    }

                    else if (choice == "display" || choice == "4")
                    {
                        DisplayTerrarium(lanTerList);
                        break;
                    }
                    
                    else if (choice == "exit")
                    {
                        System.Environment.Exit(1);
                    }
                    else if (choice == "back" || choice == "5")
                    {
                        break;
                        // go back to MainMenu
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                    break;
                }
            }

            return lanTerList;
        }

        public void DestroyTerrarium(List<LandTerrarium> lanTerList, string id)
        {
            try
            {
                foreach (var ter in lanTerList)
                {
                    if (ter.ID == id)
                    {
                        lanTerList.Remove(ter);
                    }
                }
            }
            catch (System.InvalidOperationException)
            {
            }
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
