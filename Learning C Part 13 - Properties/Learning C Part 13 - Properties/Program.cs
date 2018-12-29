using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Part_13___Properties
{
    class Program
    {
        class Player
        { 
            //private integers(Properties)
            //default health for the player 
            private int health = 100;
            //max possible health for the player
            private int MaxHealth = 100;
            //lowest possible health for the player
            private int MinHealth = 0;

            //using a public int Health to use to retrieve the private integers
            public int Health
            {
                //get the private int health and return it (READ ONLY)
                get
                {
                    return health;
                }
                //set the variable "health" so it is now editable
                set
                {
                    //if player health falls below 0 run this code, it'll prevent health going any lower
                    if (value <= MinHealth)
                    {
                        health = MinHealth;
                    }
                    //or if player health exceeds above 100 run this code, it'll prevent health going any higher 
                    else if (value >= MaxHealth)
                    {
                        health = MaxHealth;
                    }
                    //or if player health is between 0 or 100 the value is posted to the console, it can any number between 1 and 99 
                    else
                    {
                        health = value;
                    }
                }
            }      
        }

        static void Main(string[] args)
        {
            //creates an instance of the player class
            Player Charlie = new Player();
            //post to the console, this first line will post the default health of the player which is 100
            Console.WriteLine("You've started the game at " + Charlie.Health + "% health");
            //health has been lowered by 200 this will return 0 because of the restrictions set above
            Charlie.Health -= 200;
            //post to the console
            Console.WriteLine("Your health is at " + Charlie.Health + " you are dead");
            //health has been increased by 400 this will return 100 because of the restrictions set above
            Charlie.Health += 400;
            //post to the console
            Console.WriteLine("Your at " + Charlie.Health + "% health");
            //health has been lowered by 40 this will return 60 because 100 - 40 = 60
            Charlie.Health -= 40;
            //post to the console
            Console.WriteLine("Ouch you've been hit, your now at " + Charlie.Health + " Health");
            //this overwrites the default health of the player so it'll post 20 to the console
            Charlie.Health = 20;
            //post to the console
            Console.WriteLine("Your Health is at " + Charlie.Health);
            //await user input
            Console.ReadKey();
        }
    }
}
