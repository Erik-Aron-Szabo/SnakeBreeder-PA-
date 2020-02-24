using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public  class Program
    {
        
        public static void Main(string[] args)
        {
            SnakeMenu snakeMenu = new SnakeMenu();
            Menu mainMenu = new Menu();
            mainMenu.CreateSnakeList(); //this will be the holder of ALL snakes
            do
            {
                mainMenu.DisplayMainMenu();
                string choice = mainMenu.InputHandler("Type option with lowercase: ");
                mainMenu.Switch(choice);
            } while (true);
           



        }
    }
}
