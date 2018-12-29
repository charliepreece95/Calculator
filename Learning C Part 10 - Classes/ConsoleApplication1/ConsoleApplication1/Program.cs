using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {
        //CLASS VARIABLES 

        //creates an int named count thats equal to 0
        public static int Count = 0;
        //creates 3 variable that all have been assigned a value
        public string name;
        public int age;
        public float happiness;

        //CLASS CONSTRUCTORS
        public Animal () //creates a function called animal
        {
            //all 3 variable have been called in this function and have been given value that will be posted to the console
            name = "fred";
            age = 6;
            happiness = 0.5f;

            Count++;
        }

        public Animal (string _name, int _age, float _happiness) //creates another function called animal that holds three variables that all have been assigned a value
        {
            //this tells us that these new instances of variables will be the same as the variables above
            // name is the same as _name
            name = _name;
            age = _age;
            happiness = _happiness;

            Count++;
        }
        
        //CLASS METHODS
        public void print() //function called print
        { 
            //this writes the value thats contained in these variables e.g. name , age  to the console
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("happiness: " + happiness);
        }

    }

    class Program
    {
       public static void Main(string[] args)
        {
           //creates a new instance of the animal function 
            Animal dog = new Animal();
           //post values of the dog to the console 
            dog.print();

            Console.WriteLine();

            //creates a new instance of the animal function 
            Animal cat = new Animal("kittie", 10, 0.3f);
            //post values of the cat to the console 
            cat.print();

            Console.WriteLine();
           //counts the number of animals, which is called upon the variable "count". 
            Console.WriteLine("Number of Animals " + Animal.Count);

            //awaits user input
            Console.ReadKey();
        }
    }
}
