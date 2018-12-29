using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Similar to an array but used when the user doesn't know how many elements there will be? Array's the user know's the amount of element there will be.
            //This creates an instance called Number.
            List<int> Number = new List<int>();

            //There are three values in this list
            Number.Add(1); //memory location 0 
            Number.Add(3); //memory location 1 
            Number.Add(5); //memory location 2 
            Number.Add(4); //memory location 3 

            //for loop that gets all the elements in the list and post them to the console
            //has an index of 0, this is where the loop wil start from 
            //the index is then incremented to end the loop.
            for (int Index = 0; Index < Number.Count; Index++)
            {
                //write the numbers to the console 
                //Index represents the memory location of a number e.g. 0, 1, 2, 3,
                Console.Write(Number[Index] + ", ");
            }

            //creates an extra line in the console
            Console.WriteLine();
            //This removes the value from memory location 2
            Number.RemoveAt(2);

         //   foreach (int PostNumbers in Number) 
         //   {
         //       Console.Write(PostNumbers + ", ");
         //   }

            //same loop...this will post the same output to the console
            for (int Index = 0; Index < Number.Count; Index++)
            {
                Console.Write(Number[Index] + ", ");
            }

            //await user input
            Console.ReadKey();
        }
    }
}
