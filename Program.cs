using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList fruits = new ArrayList();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            Console.WriteLine("Total number of fruits in the ArrayList: {0}", fruits.Count);

            Console.WriteLine("Enter  a fruit to search: ");
            string elementToCheck = Console.ReadLine();

            bool containsElement = fruits.Contains(elementToCheck);

            Console.WriteLine("Does the List contain the fruits '{0}'? {1}\n", elementToCheck, containsElement);

            Console.WriteLine("Enter a fruit to insert into the ArrayList\n ");
            Console.WriteLine("Enter a position that needs to be insert");
            string elementToInsert = Console.ReadLine();

            //Console.WriteLine("Enter the position to insert the fruits list at: ");
            int positionToInsert = int.Parse(Console.ReadLine());

            fruits.Insert(positionToInsert, elementToInsert);

            Console.WriteLine("Enter a fruit to remove from the ArrayList: ");
            string elementToRemove = Console.ReadLine();

            fruits.Remove(elementToRemove);

            Console.WriteLine("!!!Fruits in the ArrayList!!!!");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
        }
    }





    
    

