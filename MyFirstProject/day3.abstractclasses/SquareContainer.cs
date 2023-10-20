using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.abstractclasses
{
    internal class SquareContainer:Container
    {
        public override double AreaOfBase(int length)
        {
            double area = length * length;
            Console.WriteLine("Square Area = " + area);
            return area;
        }

    }
}
