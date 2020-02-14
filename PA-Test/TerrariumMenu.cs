using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class TerrariumMenu : Menu
    {
        public SmallTerrarium smallTer = null;
        public NormalTerrarium normalTer = null;
        public LuxuryTerrarium LuxuryTer = null;
        public void DisplayTerrariumMenu()
        {
            Console.WriteLine("Terrarium Menu");
            Console.WriteLine("(1) Create");
            Console.WriteLine("(2) Destroy");
            Console.WriteLine("(3) Add (Snakes)");
            Console.WriteLine("(4) ----    ");
            Console.WriteLine("() Back");
            Console.WriteLine("() Exit");
        }

        public void TerrariumSwitch(string choice)
        {
            
            //maybe a WHILE here?
            try
            {
                if (choice == "create")
                {

                    Console.WriteLine("What kind of Terrarium would you like to create?");
                    Console.WriteLine("(1) Small");
                    Console.WriteLine("(2) Normal");
                    Console.WriteLine("(3) Luxury");
                    Console.WriteLine("(4) ------");
                    string uiChoice = Console.ReadLine();
                    try
                    {
                        if (uiChoice == "small")
                        {
                            Console.WriteLine("ID of Terrarium: (type a number) ");
                            int uiID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Capacity of Terrarium: (how many snakes can be housed there?)");
                            int uiGallon = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Temperature of Terrarium: ");
                            int uiTemperature = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Humidity of Terrarium: ");
                            int uiHumidity = Convert.ToInt32(Console.ReadLine());

                            smallTer = new SmallTerrarium(uiID, uiGallon, uiTemperature, uiHumidity);
                        }
                        else if (choice == "normal")
                        {
                            Console.WriteLine("ID of Terrarium: (type a number) ");
                            int uiID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Capacity of Terrarium: (how many snakes can be housed there?)");
                            int uiGallon = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Temperature of Terrarium: ");
                            int uiTemperature = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Humidity of Terrarium: ");
                            int uiHumidity = Convert.ToInt32(Console.ReadLine());

                            normalTer = new NormalTerrarium(uiID, uiGallon, uiTemperature, uiHumidity);
                        }
                        else if (choice == "luxury")
                        {
                            Console.WriteLine("ID of Terrarium: (type a number) ");
                            int uiID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Capacity of Terrarium: (how many snakes can be housed there?)");
                            int uiGallon = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Temperature of Terrarium: ");
                            int uiTemperature = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Humidity of Terrarium: ");
                            int uiHumidity = Convert.ToInt32(Console.ReadLine());

                            LuxuryTer = new LuxuryTerrarium(uiID, uiGallon, uiTemperature, uiHumidity);
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid input!");
                    }

                    
                }
                else if (choice == "destroy")
                {
                    //
                }
                else if (choice == "add")
                {
                    // add snake into terrarium
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

                Console.WriteLine("Invalid input!");
            }
        }
        public TerrariumMenu()
        {

        }
        
    }
}
