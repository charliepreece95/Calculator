using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //creates a ENUM called "Breed" that holds different breeds of dog
        enum Breed{ Husky , boxer , greyhound , pug , bulldog , shepherd , labrador};

        //base class
        class Animal
        {
            //3 variables with names
            public string name;
            public int age;
            public float happiness;
        }

        //derived class 
        class Dog : Animal
        {
            //variable called breed is added into the mix 
            //uses the ENUM name "Breed"
            public Breed Breed;
            //constructor that carrys the same name of another
            public Dog(string _name , int _age , float _happiness , Breed _breed)
            {
                //different name but same value
                name = _name;
                age = _age;
                happiness = _happiness;
                //new data about the dog called breed
                Breed = _breed; 
            }

            //prints the info about the DOG to the console
            public void Print()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);

                Console.WriteLine("Breed: " + Breed);
            }
        }

        static void Main(string[] args)
        {
            //create an instance of the derived class DOG
            Dog Rascal = new Dog("Rascal" , 4 , 0.8f , Breed.Husky); //give the dog some info (Has to strictly contain 4 arguements/values)
            Rascal.Print(); //print the info about the DOG to the console

            //await user input 
            Console.ReadKey();
        }
    }
}
