using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    public sealed class Singelton
    {
        public  static int counter =0;
        public static Singelton instance = null;
        public static Singelton singeltonobj { 
            get{
           
                if (instance == null)
                       instance = new Singelton();
                return instance;
            }
        }
        private  Singelton()
        {
            Console.WriteLine("Total Object Created"+counter);

        }
               
        public void PrintMessage(string Message)
        {
            Console.WriteLine(Message);
            
        }


    }
}
