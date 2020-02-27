using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PA_Test
{
    public class SnakeMenu : Menu
    {

        public List<Snake> ProgramToClass(List<Snake> snakes)
        {
            List<Snake> snakeList;
            snakeList = snakes;
            return snakeList;
        }
        
        public void DisplaySnakeMenu()
        {
            Console.WriteLine("Snake Menu");
            Console.WriteLine("(1) Create (creates and adds snake to List)");
            Console.WriteLine("(2) Destroy (takes snake out of the List)");
            Console.WriteLine("(3) Update (update snake's name)");
            Console.WriteLine("(4) Display (all snakes)");
            Console.WriteLine("(4) Back");
            Console.WriteLine("(5) Exit");
        }

        public List<Snake> SnakeSwitch(string choice, List<Snake> snakeList, string filename)
        {

            //maybe a WHILE here?
            try
            {
                if (choice == "create")
                {
                    AddSnakeToList(CreateSnake(snakeList), snakeList);
                    Console.WriteLine("Done!");
                }
                else if (choice == "destroy")
                {
                    Console.WriteLine("Name: ");
                    string uiName = Console.ReadLine();
                    Console.WriteLine("Type: ");
                    string uiType = Console.ReadLine();
                    theXml.WriteToXmlFile(DeleteSnake(uiName, uiType, snakeList), filename);
                    Console.WriteLine("Done!");
                }
                else if (choice == "update")
                {
                    Console.WriteLine("Name of the snake you want to update: ");
                    string uiName = Console.ReadLine();
                    UpdateSnake(uiName, snakeList);
                    Console.WriteLine("Done!");
                }
                else if (choice == "display")
                {
                    DisplayAllSnakes(snakeList);
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

                Console.WriteLine("Type with lowercase maybe.");
            }

            return snakeList;
        }


        public void AddSnakeToList(Snake snake, List<Snake> snakeList)
        {
            snakeList.Add(snake);
        }

        public Snake CreateSnake(List<Snake> snakeList) //XML writes it also
        {
            Snake Hul = new Snake(); //HashSet instead of list?
            Console.WriteLine("Name: ");
            string uiName = Console.ReadLine();
            Console.WriteLine("Type: ");
            string uiType = Console.ReadLine();
            Hul.Name = uiName;
            Hul.Type = uiType;
            return Hul;

        }
        public List<Snake> DeleteSnake(string name, string type, List<Snake> snakeList)
        {
            // if snake's name are the same, it will delete both snakes.
            try
            {
                int counter = 0;
                foreach (var snake in snakeList.ToList())
                {
                    if (name == snake.Name && type == snake.Type)
                    {
                        if (counter >= 1)
                        {
                            Console.WriteLine("There are more than 1 snakes with the same name and type!\nBoth will be deleted!"); //maybe the User can decide if he wants to delete all snakes?
                        }
                        snakeList.Remove(snake);
                        counter++;
                    }
                }
            }
            catch (Exception ok)
            {
                Console.WriteLine(ok);
                Console.WriteLine("Check given name!");
            }
            return snakeList;
        }

        public void UpdateSnake(string name, List<Snake> snakeList)
        {
            try
            {
                foreach (var snake in snakeList)
                {
                    if (name == snake.Name)
                    {
                        Console.WriteLine("New Name: ");
                        string newName = Console.ReadLine();
                        Console.WriteLine("New Type: ");
                        string newType = Console.ReadLine();
                        snake.Name = newName;
                        snake.Type = newType;
                        Console.WriteLine("Update successful!");
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Check given name!");
            }
        }

        public void DisplayAllSnakes(List<Snake> snakeList)
        {
            foreach (Snake item in snakeList)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Name: {item.Name}");
            }
        }
    }
}
