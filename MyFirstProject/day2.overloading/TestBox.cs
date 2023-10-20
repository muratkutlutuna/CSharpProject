using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.overloading
{
    internal class TestBox
    {
        static void Main()
        {
            Box obj = new Box();

            obj.CalculateArea(4.56);
            obj.CalculateArea(4, 7);
            obj.CalculateArea(3);
        }
    }
}
