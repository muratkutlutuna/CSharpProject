using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.examples
{
    internal class Employee
    {
        public double salary;
        public double bonus;

        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total Pay = "+totalPay);
        }
    }
}
