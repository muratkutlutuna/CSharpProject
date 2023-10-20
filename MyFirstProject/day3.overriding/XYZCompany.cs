using MyFirstProject.day3.overriding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.sampleproject
{
    internal class XYZCompany
    {
        static void Main()
        {
            Employee alex = new Employee();
            alex.CalculateTax(120000);
            alex.CalculateVacation(7);

            Console.WriteLine("--------------------");

            PartTimeEmployees lynda = new PartTimeEmployees();
            lynda.CalculateTax(120000);
            lynda.CalculateVacation(7);
            lynda.PrintContractDetails();
        }
    }
}
