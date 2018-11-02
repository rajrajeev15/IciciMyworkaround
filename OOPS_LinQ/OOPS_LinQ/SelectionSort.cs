using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class SelectionSort
    {
        static int[] a = new int[] { 15,20,18,25,22,34,13 };
        static int k = 0;
        static void Main(string[] args)
        {
            reverseSelection(a);
        }

        private static void reverseSelection(int [] arr1)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
               
                for (int j = 1; j < a.Length - 1; j++)
                {
                    int temp = 0;

                    if (a[k] < a[j])
                    {
                        temp = a[k];
                        a[k] = a[j];
                        a[j] = temp;

                        k = k + 1; 
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
