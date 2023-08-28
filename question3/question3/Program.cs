using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer<int> a = new Integer<int>();
            a.show(50);

            String<string> b = new String<string>();
            b.show("Hello world");
            Console.ReadKey();
        }
    }
}
