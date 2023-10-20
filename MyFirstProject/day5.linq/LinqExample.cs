using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.linq
{
    internal class LinqExample
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            nums.Add(1);nums.Add(-2);nums.Add(3);nums.Add(0);
            nums.Add(-4);nums.Add(5);nums.Add(11);
            //Create a query that obtains only positive numbers.
            var posNums = from n in nums
                          where n > 0
                          select n;

            Console.Write("The positive values in nums: ");
            //Execute the query and display the results.
            foreach(int i in posNums)
                Console.Write(i+" ");
            Console.WriteLine("\n---------------");
            var posNumRange = from n in nums
                              where n > 0 && n<10
                              select n;
            foreach(int i in posNumRange) Console.Write(i+" ");
            Console.WriteLine("\n---------------");
            var posNumOrder = from n in nums
                              orderby n descending
                              select n;
            foreach (int i in posNumOrder) Console.Write(i + " ");
            Console.WriteLine("\n---------------");
            var sqrRoots = from n in nums
                           where n > 0
                           select Math.Sqrt(n);
            foreach (double i in sqrRoots) Console.Write("{0:#.##} ", i);
            Console.WriteLine("\n---------------");
            var queryResults = from n in nums
                           where n > 0
                           select n;
            Console.WriteLine("Count "+queryResults.Count());//query executes
            Console.WriteLine("Max " + queryResults.Max());
            Console.WriteLine("Min " + queryResults.Min());
            Console.WriteLine("Average " + queryResults.Average());
            Console.WriteLine("Sum " + queryResults.Sum());

            Console.WriteLine("\n---------------");
        }
    }
}
