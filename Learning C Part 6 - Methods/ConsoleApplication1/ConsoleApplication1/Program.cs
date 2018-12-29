using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) //This is a method called MAIN, it is called when the program starts
        {
            //the assignment operator is used to add two numbers and generate a result
            //the numbers in brackets are recognised as num1 and num2 because the method 'Add' is being called which contains both num1 and num2 definitions below
            int Result = Add(1, 8);
     
            //simple if statement to generate an output depending on the actual answer
            //which ever line of code is executed depends on the variable result, which holds the actual answer  
            if (Result > 10)
            {
                //if the answer is larger than 10 then this will print to the console
                Console.WriteLine("The answer is " + Result + " this answer is larger than 10");
            } 
            else
            {
                //otherwise if the answer is lower or equal to 10 then this line of code will run instead
                Console.WriteLine("The answer is " + Result + " This answer is less than or equal to 10");
            }
            //awaits user input
            Console.ReadKey();
        }
        //this is a method called Add, it called when two numbers are added 
        public static int Add(int Num1 , int Num2) //two integers called num1 and num2  
        {
            //return the result generated above
            return Num1 + Num2;
        }
    }
}
