using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.constructor
{
    internal class TestSmallBox
    {
        static void Main()
        {
            SmallBox fedEx1 = new SmallBox();
            //fedEx1.length = 6;
            //fedEx1.width = 5;
            fedEx1.CalculateArea();

            SmallBox fedEx2 = new SmallBox(3,4);
            //fedEx1.length = 6;
            //fedEx1.width = 5;
            fedEx2.CalculateArea();

            SmallBox ups = new SmallBox();
            ups.CalculateArea();
        }
    }
}
