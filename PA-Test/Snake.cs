using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class Snake
    {
        public string Name { get; set; }
        public string Type { get; set; } // water, sand, mountain

        public Snake(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public Snake()
        {

        }
    }
}
