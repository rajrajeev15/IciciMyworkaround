using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class TaskExample
    {

        static void Main(string[] args)
        {

            Task t = new Task(PrintHello);
            t.Start();
            Console.ReadLine();


        }


        public static void PrintHello()
        {
            List<string>country = new List<string>(){
            "India","Pakistan","Aurangabad"
            
            };

            string s ="";
            var x = Parallel.ForEach(country, (item) => { Console.WriteLine(item); });

        
          }
    }
}
