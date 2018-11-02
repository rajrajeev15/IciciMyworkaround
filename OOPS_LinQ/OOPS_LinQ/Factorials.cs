using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class Factorials
    {
        static int fact = 1;
        static void Main(string[] args)
        {
            calculateFactorial(5);
            Console.ReadLine();
        }


        public static void calculateFactorial(int num)
        {
            //if (num == 0)
            //    fact = fact*1;

            if (num > 0)
            {
                fact = fact * num;
                num = num - 1;
                calculateFactorial(num);
                            
            
            }
            else
                Console.WriteLine("factorial iss"+fact);



        }
    }
}
