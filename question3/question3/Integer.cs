﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Integer<T> :ginterface<int>
    {
        public void show(int value)
        {
            Console.WriteLine("Value: " + value);
        }

    }
}
