using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    [Serializable]
    public class WaterTerrarium : Terrarium
    {
        //public override string Type
        //{
        //    get
        //    {
        //        return this.Type;
        //    }

        //    protected set
        //    {
        //        Type = "Water";
        //    }
        //}
        public override void AddSnake(Snake snake) //Override MISSING
        {
            if (snake.Type.ToLower() == "water")
            {
                SnakeList.Add(snake);
            }
        }

        public WaterTerrarium()
        {

        }

        public override void DisplayContents()
        {
            throw new NotImplementedException();
        }

        public WaterTerrarium(string id, List<Snake> snakes)
        {
            ID = id;
            SnakeList = snakes;
            Type = "Water"; //Unnecessary maybe?
        }
        public override string ToString()
        {
            string snakes = "";
            foreach (var snake in this.SnakeList)
            {
                snakes += $"Snake's Name: {snake.Name}; Snake's Type: {snake.Type}\n";
            }
            return $"ID: {this.ID}\n{snakes}\nType: {this.Type}\n";
        }

        public override void SnakeChecker(List<Snake> snakeList)
        {
            foreach (var snake in snakeList)
            {
                if (snake.Type != "Water" || snake.Type != "water")
                {
                    Console.WriteLine("Invalid Snake type! (It is not 'water/Water')");
                }
                else
                {
                    this.SnakeList.Add(snake);
                    snakeList.Remove(snake);
                }
            }
        }
    }
}
