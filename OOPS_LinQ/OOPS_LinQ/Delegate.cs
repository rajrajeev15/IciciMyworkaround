using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class Delegate
    {
        public  delegate void del_name(String Name);

        static void Main(string[] args)
        {
            Delegate dL = new Delegate();
            del_name dl = new del_name(dL.SayHello);
            del_name dl1 = new del_name(dL.SayByee);
            del_name dl2 = new del_name(dL.SayHii);
            dl += dl1;
            dl += dl2;
            dl("Rajeev");
          

         

            Console.ReadLine();
        }


        public void SayHello(string Name)
        {
            Console.WriteLine("Hello" + Name);
        
        }
        public void SayHii(string Name)
        {
            Console.WriteLine("Hii" + Name);

        }
        public void SayByee(string Name)
        {
            Console.WriteLine("Byee" + Name);

        }
    }
}
