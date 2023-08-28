using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class String<T>:ginterface<String>
    {
        public void show(String str)
        {
            Console.WriteLine("Value: " + str);
        }
    }
}
