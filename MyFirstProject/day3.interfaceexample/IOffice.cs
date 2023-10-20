using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.interfaceexample
{
    interface IOffice
    {
        void New();
        void Save();
        void Print();

        void Insert()
        {
            Console.WriteLine("Insert Method");
        }
    }
}
