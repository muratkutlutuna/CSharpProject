using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleWhile
    {
        static void Main()
        {
            int x = 10;

            while (x >= 0)
            {
                Console.WriteLine(" x = "+x);
                x--;//x=x-1;
            }
        }
    }
}
