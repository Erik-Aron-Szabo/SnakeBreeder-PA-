using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class SmallTerrarium : Terrarium
    {


        public override void AddSnake()
        {
            throw new NotImplementedException();
        }

        public override void DisplayContents()
        {
            throw new NotImplementedException();
        }

        public SmallTerrarium(int id, int capacity, int temperature)
        {
            ID = id;
            Capacity = capacity;
            Temperature = temperature;
        }

    }
}
