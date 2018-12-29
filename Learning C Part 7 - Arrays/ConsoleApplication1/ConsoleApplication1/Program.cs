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
            //New Array called numbers that holds 3 integer values
            int[] Numbers = new int[3];

            //3 values have a memory location starting at 0, which are assigned a value
                Numbers[0] = 1;
                Numbers[1] = 2;
                Numbers[2] = 3;
           
          //This for loop has an index which starts at zero(This is the location it'll start to loop)
          //The loop retrives all integer values from the array, the property .Length gets the numbers from the array, this the Index is incremented "Index++;"
          for (int Index = 0; Index < Numbers.Length; Index++) //increments the index by 1, stops the program from looping for eternity after one pass.
            
              {
                //write the array values to the console
                Console.Write(Numbers[Index] + ", ");
              }
            
      //     foreach (int Number in Numbers)
      //    {
      //       Console.Write(Number + ", ");
      //    }
      
            Console.ReadKey();
        }
    }
}
