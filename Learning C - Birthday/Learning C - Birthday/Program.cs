using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new DateTime(1998, 08, 08);
            var now = DateTime.Now;
            var difference = now - birthday;
            var age = difference.Days / 365;

            Console.WriteLine("Your Birthday is " + birthday.ToLongDateString());
            Console.WriteLine(difference.Days + " Days on Earth");
            Console.WriteLine("You are " + age);
        
            Console.ReadLine();
        }
    }
}
