using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class Employee
    {
        static void Main(string[] args)
        {
            Singelton s = Singelton.singeltonobj;
            s.PrintMessage("Called for Employee");

            Singelton s1 = Singelton.singeltonobj;
            s.PrintMessage("Called for EmployeeSecond Time");

            Console.ReadLine();
        }
    }
}
