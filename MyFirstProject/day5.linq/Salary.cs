using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.linq
{
    internal class Salary
    {
        public int EId { get; set; }
        public double salary { get; set; }
        public Salary(int id, double salary)
        {
            this.EId = id;
            this.salary = salary;
        }
    }
}
