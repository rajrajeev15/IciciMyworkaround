
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
   public partial class Partial
    {

        public void f1()
        {

            Console.WriteLine("from partial 1");
        }

     
       
    }


    public partial class Partial
    {

        public void f2()
        {

            Console.WriteLine("from partial 2");
        }

     


    }

    public class executePartial
    {
        static void Main(string[] args)
        {
            Partial p1 = new Partial();
            p1.f1();
            p1.f2();
        
            Console.ReadLine();
            
        }
    
    }
}
