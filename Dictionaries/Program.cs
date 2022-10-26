using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static Dictionary<string, string> itemDescriptions = new Dictionary<string, string>();

        static void FillInventory()
        {
            itemDescriptions.Add("Phone", "This is yours.");
            itemDescriptions.Add("Health Potion", "It tastes awful but it works");
            itemDescriptions.Add("Apple", "Food for a health nut");
            itemDescriptions.Add("Apple Juice", "Liquid apples");
            itemDescriptions.Add("Book", "It's written in a language you don't know");
            itemDescriptions.Add("Letter", "This doesn't belong to you, don't read it");
            itemDescriptions.Add("Key", "Used to open locks");
        }

        static void ShowInventory()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inventory (" + itemDescriptions.Count.ToString() + " items)");
            foreach(string item in itemDescriptions.Keys)
            {
                Console.WriteLine("|" + item + "|");
            }
            Console.ResetColor();
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            
        }
    }
}
