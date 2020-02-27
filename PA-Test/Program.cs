using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PA_Test
{
    public  class Program
    {
        
        public static void Main(string[] args)
        {
            if (!File.Exists("JustSnakes.xml"))
            {
                //File.Create("JustSnakes.xml");
                File.WriteAllText("JustSnakes.xml", "<ArrayOfSnake></ArrayOfSnake>");

            }
            XML theXml = new XML();
            //string path = @"C:\CSharp\PA-Test\SnakeBreeder2\SnakeBreeder-PA-\PA-Test\AllSnakes.xml"; // maybe let user type it?
            string filename = "JustSnakes.xml";
            List<Snake> snakeList = theXml.SnakeLoadObjectFromXmlFile(filename); // All snakes
            //for (int i = 0; i < 3; i++)
            //{
            //    Snake a = new Snake();
            //    Console.WriteLine("N");
            //    string n = Console.ReadLine();
            //    Console.WriteLine("t");
            //    string t = Console.ReadLine();
            //    a.Name = n;
            //    a.Type = t;
            //    snakeList.Add(a);
            //}
            Menu mainMenu = new Menu();
            do
            {
                mainMenu.DisplayMainMenu();
                string choice = mainMenu.InputHandler("Type option with lowercase: ");
                if (!mainMenu.Switch(choice, snakeList, filename))
                    break;
                
            } while (true);
            //foreach (var snake in snakeList)
            //{
            //    Console.WriteLine(snake.Name);
            //    Console.WriteLine(snake.Type);
            //}
            //theXml.WriteToXmlFile(snakeList, filename);
            Console.WriteLine("Done");


        }
    }
}
