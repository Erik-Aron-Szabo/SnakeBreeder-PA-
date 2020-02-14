using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PA_Test
{
    public class SnakeMenu : Menu
    {
        List<Snake> snakeList = new List<Snake>();

        //this is where ALL the snakes are
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

        public void SnakeSwitch(string choice)
        {

            //maybe a WHILE here?
            try
            {
                if (choice == "create")
                {


                    Console.WriteLine("Name: ");
                    string uiName = Console.ReadLine();
                    int h = 0;
                    int ha = 100;
                    Snake Hul = new Snake(uiName, h, ha);
                    SnakeToList(Hul);
                    Console.WriteLine("Done!");
                }
                else if (choice == "destroy")
                {
                    Console.WriteLine("Name: ");
                    string uiName = Console.ReadLine();
                    DeleteSnake(uiName, snakeList);
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
                    // Exit the program
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
            
        }

        public SnakeMenu()
        {

        }

        public void SnakeToList(Snake snake)
        {
            snakeList.Add(snake);
        }

        public void DeleteSnake(string name, List<Snake> tempSnakeList)
        {
            try
            {
                foreach (var item in tempSnakeList)
                {
                    if (name == item.Name)
                    {
                        tempSnakeList.Remove(item);
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Check given name!");
            }
        }

        public void UpdateSnake(string newName, List<Snake> tempSnakeList)
        {
            try
            {
                foreach (var item in tempSnakeList)
                {
                    if (newName == item.Name)
                    {
                        item.Name = newName;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Check given name!");
            }
        }

        public void DisplayAllSnakes(List<Snake> tempSnakeList)
        {
            foreach (Snake item in tempSnakeList)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Hunger: {item.Hunger}");
                Console.WriteLine($"Happiness: {item.Happiness}");
            }
        }

    }
}
