using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.day4.exceptionhandling
{
    internal class TeamB
    {
        static void Main()
        {
            TeamA obj = new TeamA();

            try
            {
                Console.WriteLine(obj.DivideNums(6, 0));
            }
            catch(Exception e)
            {
                Console.WriteLine("Message : " + e.Message);
            }
        }
    }
}
