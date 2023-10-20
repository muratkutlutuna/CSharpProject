using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.delegates
{
    public class Employee
    {
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public decimal TotalPay { get; set; }
        public void CalculateTotalPay()
        {
            TotalPay = Salary + Bonus;
            Console.WriteLine("Total pay = "+TotalPay);
        }
    }
}
