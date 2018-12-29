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
            //write this to the console
            Console.WriteLine("How old are you");
            //declare a variable called age and convert it from a string to an integer
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18) //Condition that states IF over 18 run this
            {
                //write this to the console
                Console.WriteLine("Your old enough");
            }
            else if (age == 18) //Condition that states IF equal to 18 run this
            {
                //write this to the console
                Console.WriteLine("Your just old enough");
            }
            else if (age < 18) //Condition that states IF below 18 run this
            {
                //write this to the console
                Console.WriteLine("You are not old enough");
            }

            //awaits user input
            Console.ReadKey();

        }
    }
}
