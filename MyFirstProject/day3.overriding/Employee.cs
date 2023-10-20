using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.overriding
{
    internal class Employee
    {
        public void CalculateTax(double pay) {
            if (pay > 100000) 
            {
                Console.WriteLine("Tax = " + (pay * .30));
            }
            else
            {
                Console.WriteLine("Tax = " + (pay * .20));
            }
        }

        public virtual void CalculateVacation(int grade)
        {
            if (grade > 5)
            {
                Console.WriteLine("Vacation days = " + 10);
            }
            else
            {
                Console.WriteLine("Vacation days = " + 7);
            }
        }

    }
}
