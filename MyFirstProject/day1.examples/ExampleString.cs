using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleString
    {
        static void Main()
        {

            //manipulate text
            string x = "David Beckham";
            Console.WriteLine("Hello " + x);
            Console.WriteLine(x.ToUpper());
            Console.WriteLine(x.Substring(2));//vid Beckham
            Console.WriteLine(x.Substring(4,5));//d Bec
            Console.WriteLine(x.IndexOf("v"));//2
            Console.WriteLine(x[1]);//a

            Console.WriteLine("---------------");

            string[] y = { "one", "two", "three" };
            foreach (string s in y) Console.WriteLine(s);
            Console.WriteLine("---------------");

            string age = "34";
            string sal = "97456.71";

            int g = Convert.ToInt32(age);
            Console.WriteLine(g/2);

            Console.WriteLine(Convert.ToDouble(sal)* .02);

        }
    }
}
