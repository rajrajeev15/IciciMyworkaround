using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    
#region Equals vs == 
		 
	
        class equalOperators
        {
            static void Main(string[] args)
            {
                string name = "sandeep";
                string myName = name;
                Console.WriteLine("== operator result is {0}", name == myName);
                Console.WriteLine("Equals method result is {0}", name.Equals(myName));
                Console.ReadKey();
            }
        }
#endregion


       
    }  


