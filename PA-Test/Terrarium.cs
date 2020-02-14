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
        public int Humidity { get; set; }

        public abstract void AddSnake();

        public abstract void DisplayContents();

        

    }
}
