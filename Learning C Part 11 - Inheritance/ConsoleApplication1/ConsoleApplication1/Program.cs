using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //INHERITANCE
        //Base class
        class Animal
        {
            //3 public properties
            public string name;
            public int age;
            public float happiness;

            //3 methods to print values to the console
            public void PrintBase()
            {
                Console.WriteLine("Name " + name);
                Console.WriteLine("Age " + age);
                Console.WriteLine("Happiness " + happiness);    
            }
        }
        //Derived Class 
        class Dog : Animal
        {
            public int SpotCount;           
      
            public void Bark()
            {
                Console.WriteLine("Bark");
                base.happiness += 0.1f;
            }
        }
        //Derived Class
        class Cat : Animal
        {
            public float Cuteness;

            public void Meow()
            {
                Console.WriteLine("Meow");
            }
        }

        static void Main(string[] args)
        {
            //Instance of the derived class
            Dog Spotty = new Dog();
            Spotty.name = "Spotty";
            Spotty.age = 4;
            Spotty.happiness = 0.8f;
            Spotty.SpotCount = 25;
            Spotty.PrintBase();
            Spotty.Bark();
            Console.WriteLine("New Happiness " + Spotty.happiness);

            Console.WriteLine();

            //Instance of the derived class
            Cat Bruno = new Cat();
            Bruno.name = "Bruno";
            Bruno.age = 12;
            Bruno.happiness = 0.2f;
            Bruno.Cuteness = 45;
            Bruno.PrintBase();
            Bruno.Meow();

            //await user input
            Console.ReadKey();
        }
    }
}
