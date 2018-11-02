using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
  
        public sealed class Circle
        {
            private double radius;

            public double Calculate(Func<double, double> op)
            {
               // 

               double x =  op(5);
               Console.WriteLine(x);

                return op(radius);
            }

            static void Main(string[] args)
            {
                Circle c = new Circle();


                //  Func<double,double> op = 

                c.Calculate((x) => x * 20);

                Console.ReadLine();
            }
        }
    
}
