using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day3.interfaceexample
{
    internal class TestOffice
    {
        static void Main()
        {
            IOffice obj = new Word();
            obj.Save();
            obj.Insert();

            IOffice obj2 = new Excel();
            obj2.Save();
            obj2.Insert();
        }
    }
}
