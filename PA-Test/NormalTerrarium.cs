﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Test
{
    public class NormalTerrarium : Terrarium
    {
        public override void AddSnake()
        {
            throw new NotImplementedException();
        }

        public override void DisplayContents()
        {
            throw new NotImplementedException();
        }

        public NormalTerrarium(int id, int capacity, int temperature, int humidity)
        {
            ID = id;
            Capacity = capacity;
            Temperature = temperature;
            Humidity = humidity;
        }
    }
}
