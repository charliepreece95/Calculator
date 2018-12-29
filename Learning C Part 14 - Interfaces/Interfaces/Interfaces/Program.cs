using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        //interface 1 Iitem 
        interface Iitem
        {
            //properties that read and write
            string name { get; set; }
            int value { get; set; }
            //currently empty methods
            void Equip();
            void Sell();
        }
        //interface 2 IDamagable 
        interface IDamagable
        {
            //property that reads and writes
            int Durability { get; set; }
            //currently an empty method
            void Damage(int _dmgAmount);
        }
        //interface 3 IPartOfQuest
        interface IPartOfQuest
        {
            //empty method
            void TurnIn();
        }

        //new class called sword that is deriving all interfaces
        class Sword : Iitem, IDamagable, IPartOfQuest
        {
            //sword properties
            public string name { get; set; }
            public int value { get; set; }
            public int Durability { get; set; }
            //constructor
            public Sword(string _name)
            {
                //give the properties values
                name = _name;
                value = 100;
                Durability = 30;
            }
            //give this method something to write to the console
            public void Equip()
            {
                Console.WriteLine(name + " Equipped");
            }
            //give this method something to write to the console
            public void Sell()
            {
                Console.WriteLine(name + " Sold for " + value + " dollars");
            }
            //give this method something to write to the console
            public void Damage(int _dmg)
            {
                //durability - damage = remaining durability (subtract the damage to get the remaining durability)
                Durability -= _dmg;
                Console.WriteLine(name + " damaged by " + _dmg + " it now has a durability of " + Durability);
            }
            //give this method something to write to the console
            public void TurnIn()
            {
                Console.WriteLine(name + " Turned in");
            }
        }

        //new class called sword that is deriving all interfaces
        class Axe : Iitem, IDamagable
        {
            //axe properties
            public string name { get; set; }
            public int value { get; set; }
            public int Durability { get; set; }
            //constructor
            public Axe(string _name)
            {
                //give the properties values
                name = _name;
                value = 100;
                Durability = 30;
            }
            //give this method something to write to the console
            public void Equip()
            {
                Console.WriteLine(name + " Equipped");
            }
            //give this method something to write to the console
            public void Sell()
            {
                Console.WriteLine(name + " Sold for " + value + " dollars");
            }
            //give this method something to write to the console
            public void Damage(int _dmg)
            {
                //durability - damage = remaining durability (subtract the damage to get the remaining durability)
                Durability -= _dmg;
                Console.WriteLine(name + " damaged by " + _dmg + " it now has a durability of " + Durability);
            }
        }

        static void Main(string[] args)
        {
            //create an instance of the sword class
            Sword sword = new Sword("Sword of Destiny");
            //equip the sword
            sword.Equip();
            //sell the sword
            sword.Sell();
            //durability takes damage of 20
            sword.Damage(20);

            Console.WriteLine();

            //create an instance of the axe class
            Axe axe = new Axe("Axe of Wonders");
            //equip the axe 
            axe.Equip();
            //sell the axe
            axe.Sell();
            //durability takes damage of 10 
            axe.Damage(10);

            Console.WriteLine();

            //create an Inventory so that you turn in items
            //this is an "array" of items
            Iitem[] inventory = new Iitem[2];
            inventory[0] = sword;
            inventory[1] = axe;

            //loop through and turn in all quest items 
            //create an index and set it to 0 which is less than the number of items in the inventory and increment the index 
            for (int index = 0; index < inventory.Length; index++)
            {
                //check items to turn in from the inventory
                IPartOfQuest Items = inventory[index] as IPartOfQuest;
                //make sure the inventory is not empty and has an item in it.
                if (Items != null)
                {
                    Items.TurnIn();
                }
            }
            //await user input
            Console.ReadKey();
        }
    }
}