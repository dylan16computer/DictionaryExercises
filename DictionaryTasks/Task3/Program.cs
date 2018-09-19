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
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Enter person {i + 1}'s first name: ");
                string firstName = Console.ReadLine();
                Console.Write($"Enter person {i + 1}'s last name: ");
                string lastName = Console.ReadLine();
                Console.Write($"Enter person {i + 1}'s age: ");
                int age = int.Parse(Console.ReadLine());
                personDictionary.Add(digits.Next(1000, 9999), new Person(firstName, lastName, age));
            }
            int j = -1;
            foreach (KeyValuePair<int, Person> person in personDictionary)
            {
                j += 1;
                Console.WriteLine($"\n--- Person {j+1} details ---");
                Console.WriteLine($"     ID: {personDictionary.Keys.ElementAt(j)}\n     First Name: {personDictionary.Values.ElementAt(j).FirstName}\n     Last Name: {personDictionary.Values.ElementAt(j).LastName}\n     Age: {personDictionary.Values.ElementAt(j).Age}");
            }
        }
    }
}
