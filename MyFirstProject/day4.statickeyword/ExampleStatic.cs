using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.statickeyword
{
    internal class ExampleStatic
    {
        public static int staticcount;
        public int nonstaticcount;

        public void CallStaticCount()
        {
            Console.WriteLine("static count : " + staticcount);
            staticcount++;
        }
        public void CallNonStaticCount()
        {
            Console.WriteLine("non static count : " + nonstaticcount);
            nonstaticcount++;
        }

        //a static constructor is fired before the instance constructor.
        static ExampleStatic()
        {
            Console.WriteLine("Static constructor");
        }
        public ExampleStatic()
        {
            Console.WriteLine("Instance constructor");
        }
    }
}
