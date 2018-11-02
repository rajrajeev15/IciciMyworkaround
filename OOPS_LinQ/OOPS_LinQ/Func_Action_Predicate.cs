using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class Func_Action_Predicate
    {


        static void Main(string[] args)
        {
            Func<int, int, int> add = new Func<int, int, int>(Sum);
            Func<int, int, int> add1 = Sum;
            int Result = add(2, 3);
            Console.WriteLine("Result iss" + Result);

            #region Func
            // Func is a special type of delegates which takes 0 to 16 input parameters and must return a values. 
            // It can be used with Anonymous and Lamda expressions also.
            // Func with O in put parameters.
            /*
               Func is built-in delegate type.
               Func delegate type must return a value.
               Func delegate type can have zero to 16 input parameters.
               Func delegate type can be used with an anonymous method or lambda expression.
             */
            Func<string> f1 = new Func<string>(Hello);
            string s = f1();
            Console.WriteLine(s.ToString());
            #endregion


            #region Action : -
            /*
             Action delegate is same as func delegate except that it does not return anything. Return type must be void.
             Action delegate can have 1 to 16 input parameters.
             Action delegate can be used with anonymous methods or lambda expressions.
             */
            Action<int, int> ActionDelegate = new Action<int, int>(SumAction);
            ActionDelegate(1, 2);
            Console.ReadLine();
            #endregion

            #region Predicate : -
            /*
             Predicate delegate takes one input parameter and boolean return type.
             Predicate delegate must contains some criateria to check whether supplied parameter meets those criateria or not.
             Anonymous method and Lambda expression can be assigned to the predicate delegate.             
             */
            Predicate<int> PredicateDelegate = new Predicate<int>(Max);
            bool val = PredicateDelegate(1);
            Console.WriteLine(val.ToString());
            Console.ReadLine();
            #endregion
        }

        private static bool Max(int obj)
        {
            if (obj > 0)
                return true;
            else
                return false;
        }

        private static void SumAction(int arg1, int arg2)
        {
            Console.WriteLine("Called through Action Delegate");
        }

        public static int Sum(int x, int y)
        {
            return x + y;


        }

        public static string Hello()
        {

            return "Hello";

        }
    }
}
