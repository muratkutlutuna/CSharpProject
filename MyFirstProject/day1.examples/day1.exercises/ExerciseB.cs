using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day1.examples.day1.exercises
{
    internal class ExerciseB
    {
        static void Main()
        {

            String[] strs = { "3.45", "3.87", "87.98", "56.7" };
            double total = 0.0;
            
            foreach (string str in strs)
            {
                total += Convert.ToDouble(str);
            }
            Console.WriteLine("total = "+total);

        }

    }
}
