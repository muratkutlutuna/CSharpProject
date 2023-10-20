using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day2.examples
{
    internal class TestEmployee
    {
        static void Main()
        {
            Employee alex = new Employee();
            Employee lynda = new Employee();

            //Console.WriteLine(alex.bonus);
            alex.bonus = 1;

            alex.SetSalary(90000);
            //alex.bonus = 20000;
            alex.CalculateTotalPay();

            lynda.SetSalary(100000);
            //lynda.bonus = 20000;
            lynda.CalculateTotalPay();
        }
    }
}
