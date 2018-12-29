using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //write two values of the same value
            Console.WriteLine(Utility.CompareValues(10, 10));
            //write two values of the same data type
            Console.WriteLine(Utility.CompareTypes("Hello", "World"));

            //await user input
            Console.ReadLine();
        }

        //create a class called Utility
        class Utility
        {
            //create a public bool called CompareValues that has two values T01 & T02
            //give T01 & T02 a name Value01 & Value02
            public static bool CompareValues<T01, T02>(T01 Value01, T02 Value02)
            {
                //say that Value01 is equal to Value02 (Returns true if both values are exactly the same)
                return Value01.Equals(Value02);
            }

            //create a public bool called CompareValues that has two values T01 & T02
            //give T01 & T02 a name Value01 & Value02
            public static bool CompareTypes<T01, T02>(T01 Value01, T02 Value02)
            {
                //say that Value01 is equal to Value02 (Returns true if both values have the same data type e.g string)
                return typeof(T01).Equals(typeof(T02));
            }
        }
    }
}