using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.delegates
{
    internal class Program
    {
        static void Menu(string[] args)
        {
            Employee alex = new Employee();

            alex.EmpName = "Alex Rod";
            alex.Salary = 100000;
            alex.Bonus = 20000;
            alex.CalculateTotalPay();
        }

    }
}
