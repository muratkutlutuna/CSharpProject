using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.examples
{
    internal class TestBox
    {
        static void Main()
        {
            Box ups, fedEx;
            ups = new Box();
            fedEx = new Box();

            ups.length = 10;
            ups.width = 5;
            int total = ups.CalculateArea(3,4);

            fedEx.length = 7;
            fedEx.width = 5;
            total+=fedEx.CalculateArea(5,6);

            Console.WriteLine("Total area = "+total);
        }
    }
}
