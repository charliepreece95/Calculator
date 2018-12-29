using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_part_1
{
    class Program
    {
        static void Main(string[] args) //this is method "Main" which is called when the program starts
        {
            //goto loop "start"
            Start:
            //declare two variables as integers number1 and number2
            int number1;
            int number2;

            //writes this to the console
            Console.Write("Enter a number to be multiplied  ");
            //convert the string type to an int
            number1 = Convert.ToInt32 (Console.ReadLine());
            //writes this to the console
            Console.Write("Enter another number ");
            //convert the string type to an int
            number2 = Convert.ToInt32(Console.ReadLine());

            //write this to the console after user input
            Console.WriteLine (number1 + " Multiplied by " + number2 + " Is equal to "  + number1 * number2);
            
            //await user input
            Console.ReadKey();
            //add an extra line
            Console.WriteLine();
            //goto loop that loops this section of code
             goto Start;
        }
    }
}
