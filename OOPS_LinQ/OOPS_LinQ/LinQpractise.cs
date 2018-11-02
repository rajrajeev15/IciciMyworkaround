using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
    class LinQpractise
    {
         static IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 } 
          };

        static void Main(string[] args)
        {
           // WhereLinq();
           // SelectLinq();
            // objType();

            //orderBy();
            // groupBY();
            firstorDefault();

        }
        #region where
        public static void WhereLinq()
        {
           
            // print List of student whose age is between 13 to 15
            // IEnumerable<Student> studnts = studentList.Where(x => x.Age >= 13 && x.Age < 21);
            // Using Named Methods
            //IEnumerable<Student> studnts  =  studentList.Where(findStudents);
            // Using Anonymous Methods
            IEnumerable<Student> studnts = studentList.Where(delegate(Student arg) { return arg.Age >= 13 && arg.Age < 21; });


            foreach (var x in studnts)
                Console.WriteLine(x.StudentName + "-" + x.Age + "\n");

            Console.ReadLine();

        }

           

        private static bool findStudents(Student arg)
        {
            return arg.Age >= 13 && arg.Age < 21;
        }

        #endregion

        #region Select
        public static void SelectLinq()
        {

          
            IEnumerable<string> studnts = studentList.Select(x =>x.StudentName);
           var studntsList = studentList.Select(student => new {
            Name  = student.StudentName,
            Age = student.Age

            } );
            // Using Named Methods
            //IEnumerable<Student> studnts  =  studentList.Where(findStudents);
            // Using Anonymous Methods
            //IEnumerable<Student> studnts = studentList.Where(delegate(Student arg) { return arg.Age >= 13 && arg.Age < 21; });


           foreach (var x in studntsList)
           {
               Console.WriteLine(x.Age);
               Console.WriteLine(x.Name);
           }
                

            Console.ReadLine();

        }





    #endregion


       public static void objType()
       {
       
        #region ofType
        List<object> obj = new List<object>() { 1, 2, 3, 4, "Rajeev", "Kumar" };
         IEnumerable<int>numbers =  obj.OfType<int>();
           foreach (var nums in numbers)
           {
             Console.WriteLine(nums);
           
           }
           Console.ReadLine();

       
       
       }

       #region orderBy

       public static void orderBy()
       {

         
           IEnumerable<Student> students = studentList.OrderBy(x => x.StudentName);
           foreach (var student in students)
           {
               Console.WriteLine(student.StudentID + "-" + student.StudentName);

           }
           Console.ReadLine();



       }
#endregion

       #region groupBY

       public static void groupBY()
       {


           var students = studentList.GroupBy(x => x.Age);
           foreach (var student in students)
           {
               Console.WriteLine(student.Key);

               foreach (var val in student)
               {
                   Console.WriteLine(val.StudentName);
               
               }

           }
           Console.ReadLine();



       }
       #endregion

        #region single or defaut and others
     /*   ElementAt	 : Returns the element at a specified index in a collection
          ElementAtOrDefault  : Returns the element at a specified index in a collection or a default value if the index is out of range.
          First : 	Returns the first element of a collection, or the first element that satisfies a condition.
          FirstOrDefault : 	Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if index is out of range.
          Last	 : Returns the last element of a collection, or the last element that satisfies a condition
          LastOrDefault : 	Returns the last element of a collection, or the last element that satisfies a condition. Returns a default value if no such element exists.
          Single : 	Returns the only element of a collection, or the only element that satisfies a condition.
          SingleOrDefault :	Returns the only element of a collection, or the only element that satisfies a condition. Returns a default value if no such element exists or the collection does not contain exactly one element.*/

       static void firstorDefault()
       {

           IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 87 };
           IList<string> strList = new List<string>() { "One", "Two", null, "Four", "Five" };

           Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
           Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

           Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
           Console.WriteLine("2nd Element in strList: {0}", strList.ElementAt(1));

           Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
           Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

           Console.WriteLine("10th Element in intList: {0} - default int value",
                           intList.ElementAtOrDefault(9));
           Console.WriteLine("10th Element in strList: {0} - default string value (null)",
                            strList.ElementAtOrDefault(9));


           Console.WriteLine("intList.ElementAt(9) throws an exception: Index out of range");
           Console.WriteLine("-------------------------------------------------------------");
           Console.WriteLine(intList.ElementAt(9));

           IList<int> intList1 = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
           IList<string> strList1 = new List<string>() { null, "Two", "Three", "Four", "Five" };
           IList<string> emptyList = new List<string>();

           Console.WriteLine("1st Element in intList: {0}", intList1.First());
           Console.WriteLine("1st Even Element in intList: {0}", intList1.First(i => i % 2 == 0));

           Console.WriteLine("1st Element in strList: {0}", strList1.First());

           Console.WriteLine("emptyList.First() throws an InvalidOperationException");
           Console.WriteLine("-------------------------------------------------------------");
           Console.WriteLine(emptyList.First());

       
       }

        #endregion

        #endregion
    }
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }


    }
}