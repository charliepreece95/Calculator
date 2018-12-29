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
            //for loop that has a variable called Index
            //the starting number is set to zero and will loop till it reaches fifty
            //then it's incremented by adding a 1 to the index each time it loops using "++" this is done 50 times
            for (int Index = 0; Index <= 50; Index++)
            {
                if (Index % 2 == 0) //this shows only numbers that are diversible by 2 "number that can will display on the console"
                {
                //display the index output to the console
                Console.WriteLine(Index + " ");
                }
            }
                //await user input
                Console.ReadKey();
        }
    }
}
