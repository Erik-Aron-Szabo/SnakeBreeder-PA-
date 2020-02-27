using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace PA_Test
{
    [Serializable]
    public class Snakes
    {
        List<Snake> ListSnake { get; set; }

        public Snakes(List<Snake> snakeList)
        {
            ListSnake = snakeList;
        }
        public override string ToString()
        {
            foreach (var snake in ListSnake)
            {
                Console.WriteLine($"Name: {snake.Name}");
                Console.WriteLine($"Type: {snake.Type}\n");
            }
            return base.ToString();
        }
    }
}
