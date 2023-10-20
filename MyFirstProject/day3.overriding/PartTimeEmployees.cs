using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.overriding
{
    internal class PartTimeEmployees : Employee
    {
        public void PrintContractDetails()
        {
            Console.WriteLine("Print contract details xyz");
        }

        public override void CalculateVacation(int grade)
        {
            if (grade > 5)
            {
                Console.WriteLine("Vacation days = " + 8);
            }
            else
            {
                Console.WriteLine("Vacation days = " + 4);
            }
        }

    }
}
