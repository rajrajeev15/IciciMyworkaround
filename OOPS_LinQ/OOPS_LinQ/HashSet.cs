using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class HashSetExamples
    {

       static  HashSet<int> hs = new HashSet<int>();

        static void Main(string[] args)
        {
            hs.Add(1);
            hs.Add(1);
            hs.Add(2);
            hs.Add(2);


            foreach (var item in hs)
            {
                Console.WriteLine(item);
                
            }

            Console.ReadLine();
        }

    }
}
