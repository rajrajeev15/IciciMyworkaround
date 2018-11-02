using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    static class Extension
    {

        static void MethodFromExtension(this Partial p, int i) 
        {

            Console.WriteLine("call from extension method");
        
        
        }


        static void Main(string[] args)
        {
            Partial p1 = new Partial();
            p1.MethodFromExtension(1);
            Console.ReadLine();
        }

    }
}
