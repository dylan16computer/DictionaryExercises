using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random digits = new Random();
            Dictionary<int, Person> personDictionary = new Dictionary<int, Person>();
            int i = 0;
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter person {i + 1}'s first name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine($"Enter person {i + 1}'s last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine($"Enter person {i + 1}'s age ");
                int age = int.Parse(Console.ReadLine());
                personDictionary.Add(digits.Next(1000, 9999), new Person(firstName, lastName, age));
            }
            i = 0;
            foreach(KeyValuePair<int, Person> person in personDictionary)
            {
                i += 1;
                Console.WriteLine($"Person {i+1}:\nID: {personDictionary.Keys.ElementAt(i)}\nFirst Name: {personDictionary.Values.ElementAt(i).FirstName}\nLast Name: {personDictionary.Values.ElementAt(i).LastName}\nAge: {personDictionary.Values.ElementAt(i).Age}");
            }
        }
    }
}
