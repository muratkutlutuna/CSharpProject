using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.interfaceexample
{
    internal class Word : IOffice
    {
        public void Insert()
        {
            Console.WriteLine("Insert word Method");
        }
        void IOffice.New()
        {
            Console.WriteLine("Create word doc");
        }

        void IOffice.Print()
        {
            Console.WriteLine("Print word doc");
        }

        void IOffice.Save()
        {
            Console.WriteLine("Save word doc");

        }
    }
}
