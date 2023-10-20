using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.interfaceexample
{
    internal class Excel : IOffice
    {
        void IOffice.New()
        {
            Console.WriteLine("Create Excel doc");
        }

        void IOffice.Print()
        {
            Console.WriteLine("Print Excel doc");
        }

        void IOffice.Save()
        {
            Console.WriteLine("Save excel doc");
        }
    }
}
