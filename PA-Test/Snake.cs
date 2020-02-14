using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class Snake
    {
        public string Name { get; set; }
        public int Hunger { get; set; } // if hunger hits 100, snake dies
        public int Happiness { get; set; }

        public Snake(string name, int hunger, int happiness)
        {
            Name = name;
            Hunger = hunger;
            Happiness = happiness;
        }
        public Snake()
        {

        }
    }
}
