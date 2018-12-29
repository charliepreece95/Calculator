using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) //This is a method called 'Main' it is called when the program starts
        {
            //creates an instance of RandomGenerator
            //This will allow random numbers to be generated
            Random NumberGenerator = new Random();

            //Two integers to be declared below
            int NumberOfAttempts = 0;
            int Attempt = 0;

            while (Attempt != 6) //Attempts not equal too six will run this loop until 6 has be found
            {
                //Attempt's are run from 1 to 6 to find the number 6
                //The numberGenerator will continue to loop untill 6 is found
                Attempt = NumberGenerator.Next(1, 7); 
                //writes the number of attempts to the console
                Console.WriteLine("You Rolled " + Attempt + ".");
                //increment the value of attempts
                NumberOfAttempts++;
            }

            //Once the number 6 is found the loop will end and run this line of code and posted it to the console
            Console.WriteLine("It Took You " + NumberOfAttempts + " Attempts To Get 6" );

            //await user input to close the console
            Console.ReadKey();
        }
    }
}
