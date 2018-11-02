using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class ArraySort
    {
        static int[] a = new int[] { 21, 34, 23, 8,0, 23,0, 45, 31, 100 };

        static void Main(string[] args)
        {
            bool flag = true;
            for (int i = 0; i < a.Length-1 && flag; i++)
            {
                flag = false;
                for (int j = 0; j <a.Length-1; j++)
                {
                    int temp = 0;

                    if (a[j + 1] > a[j])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j+1] = temp;
                        flag = true;
                    
                    }


                }
            }

            foreach (int item in a)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();

        }
    }
}
