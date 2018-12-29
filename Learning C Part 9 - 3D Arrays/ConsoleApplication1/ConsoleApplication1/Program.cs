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
            //call the 'ArrayGrid' function
            ArrayGrid();

            //await user input
            Console.ReadKey();
        }

        public static void ArrayGrid()
        {
            //assign the height and width values a number
            int width = 10;
            int height = 10;

            //two dimentional grid that has two values called height, width.
            //[,] is two dimentional  [, ,] is three dimentional
            int[,] grid = new int[height, width];

            //for loop to print the values to the console
            //this has an integer called x that is set to 0 that is less than the width
            //x is incremented by 1
            for (int x = 0; x < width; x++)
            {
                //this is an integer called y that is set to 0, that less than the height
                //y is incremented by 1
                for (int y = 0; y < height; y++)
                { 
                    //Not sure on this line of code
                    grid [x, y] = x + y;
                    //access each parameter by calling 'grid' and the x,y position and create a space in between each number
                    Console.Write (grid [x, y] + " ");
                }
                //creates a new line, which is an iteration of x (outputs the same result but on a new line)
                Console.WriteLine();
            }  
        } 
    }
}
