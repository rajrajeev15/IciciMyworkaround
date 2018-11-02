using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class Anonymous_LambdsExpressions
    {

        static void Main(string[] args)
        {
            List<string> NameList = new List<string>() { "Rajeev" ,"Rajesh","Mahesh"};
           // Called using Named Parameter
            string result = NameList.Find(FindName);

            // Called Using Anonymous Methods
            string result2 = NameList.Find( delegate(string Name){
                                               return Name.Equals("Rajeev");
           });

            // Called Using Lambda Expression Methods
            //string result1 = NameList.Find(x=>x.Equals("Rajeev"));

            if (result != null)
                Console.WriteLine("Name Found");
            Console.ReadLine();
        }

        #region Named Method using Predicates
        private static bool FindName(string Name)
        {

            return Name.Equals("Rajeev");

        }
        #endregion

    }
}
