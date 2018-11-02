using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{

    public class A1
    {

       
        public void A11()
        {
        
        }
        public void B1()
        {
        
        }
               
    }


    static class ExtensionClass
    {

        

       public static void Add(this A1 a, int x, int y)
        {

            int z = x + y;
        
        }

       
          
    }

    public class b2 :A1
    {
        public static int? x =(int)10 ;

        static void Main(string[] args)
        {
            x = (int)x;
            A1 a = new A1();
            a.Add(2, 23);
            x = null;


        }
    
    
    }

   

}
