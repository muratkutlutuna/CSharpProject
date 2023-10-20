using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.statickeyword
{
    internal class TestStatic
    {
        static void Main()
        {
            ExampleStatic obj1 = new ExampleStatic();
            ExampleStatic obj2 = new ExampleStatic();

            Console.WriteLine("-----------------");
            ExampleStatic.staticcount = 1;
            obj1.nonstaticcount = 1;
            obj2.nonstaticcount = 1;

            obj1.CallStaticCount();
            obj2.CallStaticCount();
            obj2.CallStaticCount();

            Console.WriteLine("-----------------");

            obj1.CallNonStaticCount();
            obj2.CallNonStaticCount();
            obj2.CallNonStaticCount();

        }
    }
}
