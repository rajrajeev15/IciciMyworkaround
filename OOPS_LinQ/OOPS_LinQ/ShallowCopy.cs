using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_LinQ
{
   class ShallowCopy :  ICloneable

{

     public int I {get;set;}

     public int J {get;set;}

 

     //method for cloning object

     public object Clone()

    {

         return this.MemberwiseClone();

    }

}

class Demo

{

     public static void Main()

    {

         ShallowCopy obj=new ShallowCopy();

       //  Console.WriteLine(“--------before Shellow Clopy------”);

         ShallowCopy objClone=obj;

         obj.I=10;// setting obj value after cloning..

       //  Console.WriteLine(“objvalue : {0} \t Clone value : {1}”,obj.I,objClone.I=10);
//
    //     Console.WriteLine(“--------after Shellow Copy------”);

         ShallowCopy objClone2=(ShallowCopy)obj.Clone();  // cast object to //ShallowCopy

        obj.I=1000;  // MemberwiseClone() will not use this reference..

       // Console.WriteLine(“after using MemberwiseClone() Clone() method :{0}”,objClone2.I);

    }
}
}
