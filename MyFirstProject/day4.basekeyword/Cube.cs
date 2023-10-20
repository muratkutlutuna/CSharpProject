using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.basekeyword
{
    internal class Cube:Square
    {
        protected int somenumber = 20;

        public override double CalculateArea(int length)
        {
            double volume = base.CalculateArea(length)*6;
            Console.WriteLine("Cube Volume = " + volume);
            Console.WriteLine("Cube somenumber = " + somenumber);
            Console.WriteLine("Square somenumber = " + base.somenumber);
            return volume;
        }
    }
}
