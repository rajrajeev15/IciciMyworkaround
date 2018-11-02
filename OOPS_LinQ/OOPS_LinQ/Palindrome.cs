using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class Palindrome
    {
        static int prevnum = 1;
        static int num = 1;
        static int nextval = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("0");
            Console.WriteLine("1");

            PalindromeTest();

            Console.ReadLine();
        }


        public static void PalindromeTest() 
        {


            for (int i = 0; i < 10; i++)
            {

                nextval = prevnum + num;
                Console.WriteLine("\n"+nextval);
                prevnum = num;
                num = nextval;


            }

        
        }





    }
}
