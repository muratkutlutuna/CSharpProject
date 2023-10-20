using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.basekeyword
{
    internal class Square
    {
        protected int somenumber = 10;

        public virtual double CalculateArea(int length)
        {
            Console.WriteLine("Square Area = " + (length * length));
            return (length * length);
        }
    }
}
