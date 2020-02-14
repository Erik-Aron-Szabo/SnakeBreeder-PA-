using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class LuxuryTerrarium : Terrarium
    {

        public override void AddSnake()
        {
            throw new NotImplementedException();
        }

        public override void DisplayContents()
        {
            throw new NotImplementedException();
        }
        public LuxuryTerrarium(int id, int capacity, int temperature, int humidity)
        {
            ID = id;
            Capacity = capacity;
            Temperature = temperature;
            Humidity = humidity;
        }
    }
}
