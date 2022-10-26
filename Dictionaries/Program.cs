using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static Dictionary<string, string> inventory = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            FillInventory();
            ShowInventory();
            Describe("Phone");
            Use("Phone");
            Describe("A");
            Describe("Book");
            Use("Book");
            Describe("Apple Juice");
            Drop("Apple Juice");
            Describe("Apple");
            Use("Apple");
            Describe("Key");
            Describe("Letter");
            Use("Letter");
            Die();
        }

        static void FillInventory()
        {
            inventory.Add("Phone", "This is yours.");
            inventory.Add("Health Potion", "It tastes awful but it works");
            inventory.Add("Apple", "Food for a health nut");
            inventory.Add("Apple Juice", "Liquid apples");
            inventory.Add("Book", "It's written in a language you don't know");
            inventory.Add("Letter", "This doesn't belong to you, don't read it");
            inventory.Add("Key", "Opens locks, but there is no lock");
        }

        static void ShowInventory()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inventory (" + inventory.Count.ToString() + " items)");
            foreach(string item in inventory.Keys)
            {
                Console.WriteLine("|" + item + "|");
            }
            Console.ResetColor();
            Console.ReadKey(true);
        }

        static void Describe(string key)
        {
            Console.WriteLine("Attempting to describe " + key);
            if (inventory.ContainsKey(key))
            {
                Console.WriteLine(key + ": " + inventory[key]);
            }
            else
            {
                Console.WriteLine("Error: No " + key + "s in your inventory");
            }
            ShowInventory();
        }

        static void Drop(string key)
        {
            Console.WriteLine("Attempting to drop " + key);
            if (inventory.ContainsKey(key))
            {
                inventory.Remove(key);
            }
            else
            {
                Console.WriteLine("Error: No " + key + "s in your inventory");
            }
            ShowInventory();
        }

        static void Use(string key)
        {
            Console.WriteLine("Attempting to use " + key);
            if (inventory.ContainsKey(key))
            {
                if(key == "Apple")
                {
                    Console.WriteLine("You ate it.");
                    inventory.Remove(key);
                }else if(key == "Book")
                {
                    Console.WriteLine("You still can't read this.");
                }else if(key == "Letter")
                {
                    Console.WriteLine("The letter says: I really hope the player doesn't read this, that would be an invasion of privacy.");
                }
                else
                {
                    Console.WriteLine("You have no use for this at the moment.");
                }

            }
            else
            {
                Console.WriteLine("Error: No " + key + "s in your inventory");
            }
            ShowInventory();
        }

        static void Die()
        {
            Console.WriteLine("The player has died and lost all their stuff");
            inventory.Clear();
            ShowInventory();
        }

    }
}
