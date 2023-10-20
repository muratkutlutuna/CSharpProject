using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.inheritence
{
    class TestBox
    {
        static void Main()
        {
            Box fedEx= new Box();
            fedEx.CalculateArea(4, 5);

            BigBox ups =new BigBox();
            ups.CalculateArea(3,4);
            ups.CalculateVolume(3, 4, 5);

        }
    }
}
