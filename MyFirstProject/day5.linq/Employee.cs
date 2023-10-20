using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day5.linq
{
    internal class Employee
    {
        public int EId { get; set; }
        public string name { get; set; }
        public Employee(int id, string name)
        {
            this.EId = id;
            this.name = name;
        }
    }
}
