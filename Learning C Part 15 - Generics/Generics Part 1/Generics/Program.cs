using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the KeyValuePair class and define the data types 
            //give it a naming convention "meaning"
            //once the data types are defined, now define what data each data type will have in this case ("life", 42);
            KeyValuePair<string, int> Meaning = new KeyValuePair<string, int>("Life", 42);
            //print to the console
            Meaning.print();

            Console.ReadLine();
        }
        //create a private class called KeyValuePair that hold two undefined values

        class KeyValuePair<Tkey, Tvalue>
        {
            //give these values a name
            public Tkey key;
            public Tvalue value;

            //constructor to make these values public
            public KeyValuePair(Tkey _key, Tvalue _value)
            {
                key = _key;
                value = _value;
            }

            //print to the console
            public void print()
            {
                //writes these values to the console which are still undefined
                Console.WriteLine("Key = " + key.ToString());
                Console.WriteLine("Value = " + value.ToString());
            }                                
        }
    }
}