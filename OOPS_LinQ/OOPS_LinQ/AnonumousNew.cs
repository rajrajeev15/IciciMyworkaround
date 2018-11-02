using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class AnonumousNew
    {
        public delegate void Print(student s);
        delegate bool IsTeenAger(Student stud);
        public delegate student getStudentDel(student s);
        static void Main(string[] args)
        {

            student s = new student()
            {
                id = 1,
                name = "Rajev",
                age = 21

            };

            getStudentDel p2 = y => y ;

            p2(s);


           // p(s);

           

        


          
            Console.ReadLine();
           
        }

        Print p =  delegate(student st)
            {
                Console.WriteLine("Printed from anonymous");
            };
            
           


        //public static void print(int val)
        //{
        //    Console.WriteLine("Inside Anonymous method. Value: {0}", val);
        //}

    }

    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    
    
    }
}
