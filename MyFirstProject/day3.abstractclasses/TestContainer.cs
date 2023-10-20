using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.abstractclasses
{
    internal class TestContainer
    {
        static void Main()
        {
            SquareContainer c1 = new SquareContainer();
            c1.CalculateVolume(10, 5);

            CircleContainer c2 = new CircleContainer();
            c2.CalculateVolume(10, 5);
        }
    }
}
