using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.abstractclasses
{
    internal abstract class Container
    {
        public void CalculateVolume(int height, int length)
        {
            double volume = AreaOfBase(length) * height;
            Console.WriteLine("Volume = "+volume);
        }

        public abstract double AreaOfBase(int length);

    }
}
