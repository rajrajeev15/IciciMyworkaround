using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPS_LinQ
{
    class Countcharacters
    {

        static void Main(string[] args)
        {
            string s = "This is a fox a fox is a clever animal and can be dnagerous, please see you are not surrounded";

            List<string> splitString = s.Split(' ').ToList();

            Dictionary<string, int> characterCount = new Dictionary<string, int>();


            foreach (var item in splitString)
            {
                if (characterCount.ContainsKey(item))
                {
                    characterCount[item] = characterCount[item] + 1;
                         
                }
                else
                characterCount.Add(item,1);

            }


        }
    }
}
