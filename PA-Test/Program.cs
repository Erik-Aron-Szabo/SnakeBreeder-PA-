using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public  class Program
    {
        
        public static void Main(string[] args)
        {
            Menu mainMenu = new Menu();

            mainMenu.DisplayMainMenu();
            string choice = mainMenu.InputHandler("Type option with lowercase: ");
            mainMenu.Switch(choice);



        }
    }
}
