using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleAndOr
    {
        static void Main()
        {
            int x = -10;
            int y = 10;

            if (x > y && y>=0)
            {
                Console.WriteLine("both numbers positive");
            }else if (y >= 0 || y >= 0)
            {
                Console.WriteLine("at least one num is positive");
            }else {
                Console.WriteLine("both numbers are negative");
            }


        }
    }
}
