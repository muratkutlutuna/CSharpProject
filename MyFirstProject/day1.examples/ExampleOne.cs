using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleOne
    {
        static void Main()
        {
            Console.WriteLine("Hello World");

            int x = 10;
            int y = 3;
            int result = x+ y;

            Console.WriteLine("result = " + result);

            Console.WriteLine("{0} + {1} = {2}", x, y, (x+y));
        }
    }
}
