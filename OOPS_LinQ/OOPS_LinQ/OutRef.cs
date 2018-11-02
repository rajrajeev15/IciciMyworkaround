using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class OutRef
    {
        

        public void Number(out int i, int x)
        {
            i = 10;
            Console.WriteLine(i+x);

        }


        static void Main(string[] args)
        {
            OutRef or = new OutRef();
              int i;
            or.Number(out i,2);
        }

    }
}
