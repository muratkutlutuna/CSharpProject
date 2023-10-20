using MyFirstProject.day3.sampleproject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.collections
{
    internal class ExampleHash
    {
        static void Main()
        {
            // key value pair

            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add("Two", 2);

            Employee alex = new Employee("Alex Rod", 68);
            ht.Add("employee", alex);

            ht["car"] = "4 door";

            ht.Remove(1);
            // get the keys to loop through

            Console.WriteLine(ht["Two"]);
            Console.WriteLine("----------------");

            foreach (Object o in ht.Keys)
            {
                Console.WriteLine(o.ToString() + " : " + ht[o]);
            }

            Console.WriteLine("----------------");

            Dictionary<string,double>d1 = new Dictionary<string,double>();
            d1.Add("Alex", 100000);
            d1.Add("Linda", 110000);
            d1.Add("John", 120000);
            //get the keys
            Console.WriteLine(d1["Linda"]);
            Console.WriteLine("----------------");
            foreach (String x in d1.Keys)
            {
                Console.WriteLine(" For employee {0} the salary is {1} ", x, d1[x]);
            }
        }
    }
}
