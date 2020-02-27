using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public abstract class Terrarium
    {
        public int ID { get; set; }
        public int Capacity { get; set; } // how many snakes can be housed there
        public int Temperature { get; set; }
        public string Theme { get; set; }

        public abstract void AddSnake(Snake snake); //abba a tipusu terrariumba bele lehet e rakni a snake-t (Type alapjan)

        public abstract void DisplayContents();

        

    }
}
