using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleIf

    {
        static void Main()
        {
            int x = 10;
            int y = 20;

            if(x < y)
            {
                Console.WriteLine("X is less than y");
            }else if (x > y)
            {
                Console.WriteLine("X is greater than y");
            }else 
            {
                Console.WriteLine("X is equal to y");
            }
        }


    }
}
