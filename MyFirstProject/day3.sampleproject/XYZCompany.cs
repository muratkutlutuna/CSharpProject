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
            Employee alex = new Employee("Alex Rod",6);
            Employee lynda = new Employee("Lynda Berry", 7);
            Employee john = new Employee("John Doe", 3);
            Employee sara = new Employee("Sara Time", 7);
            Employee james = new Employee("James Doe", 4);

            Department sales = new Department("XYZ Sales");
            sales.AddEmployee(alex);
            sales.AddEmployee(lynda);
            sales.AddEmployee(john);
            sales.describe();

            Console.WriteLine("--------------------");

            Department IT = new Department("XYZ IT");
            IT.AddEmployee(sara);
            IT.AddEmployee(james);  
            IT.describe();
        }
    }
}
