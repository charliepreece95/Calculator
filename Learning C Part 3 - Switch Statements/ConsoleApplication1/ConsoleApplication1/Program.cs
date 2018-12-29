
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) //this is method "Main" which is called when the program starts
        {   
            //creates an instance of RandomGenerator
            Random RandomGenerator = new Random();

            //declare integers num01 and num02
            int num01 = RandomGenerator.Next(1,11);
            int num02 = RandomGenerator.Next(1,11);
    
    //writes this to the console
    Console.WriteLine ("What is " + num01 + " times " + num02 + "?");
    //declare another variable called answer and convert it from a string to an int
    int answer = Convert.ToInt32 (Console.ReadLine());
   
    //if a users input is correct then run this line of code
    if (answer == num01 * num02) 
    {
        //Declare a variable called responseIndex
        int ResponseIndex = RandomGenerator.Next(1, 5);

        //call the variable ResponseIndex
        switch (ResponseIndex)
        {
            //generates three random messages for inputting an Correct answer
            case 1:
                Console.WriteLine("Correct");
                break;

            case 2:
                Console.WriteLine("Well Done That's Correct");
                break;

            case 3:
                Console.WriteLine("Nailed it");
                break;

            default:
                Console.WriteLine("That's the Correct Answer");
                break;
        }
    } 
    //if false or user's input is incorrect then run this
    else 
    {
        //variable called difference
        int Difference = Math.Abs (answer - (num01 * num02)); //user answer is subtracted by the actual answer
        
        //if the user's answer is 1 off the actual answer this will run
        if (Difference == 1)
        {
            Console.WriteLine("So Close");
        }
        //if the user's answer is less than or equal to 10 off the actual answer this will run
        else if (Difference <= 10)
        {
            Console.WriteLine("Almost There");
        }
        else
        {
            //if the user's answer is more than 10 off the actual answer this will run
            Console.WriteLine("Not Even Close");
        }
    }
    //await user input
    Console.ReadKey();
    }
  }
}