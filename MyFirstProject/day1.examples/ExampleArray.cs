using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples
{
    internal class ExampleArray
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c, d, e, f;
            c = 30;
            d = 40;
            e = 50;
            f = 60;

            int a1, a2, a3;
            a1 = 10;
            a2 = 20;
            a3 = 30;
            int a4 = 40;

            int[] arr = { 10, 20, 30, 40, 50, 60 };

            Console.WriteLine(arr[3]);
            arr[4]=55;
            Console.WriteLine(arr[4]);
            
            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine("a["+i+"]="+arr[i]);
            }
            
            foreach (int tempvar in arr)
            {
                Console.WriteLine(tempvar);
            }

            //initialize array and then assign values 
            int[] x = new int[6];
            x[0] = 10;
            x[3] = 50;
            foreach (int z in x)
            {
                Console.WriteLine(z);
            }
        }

    }
}

