using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> userInputDictionary = new Dictionary<int, string>();
            for(int i = 0; i < 10; i++)
            {
                string userInput = Console.ReadLine();
                userInputDictionary.Add(i, userInput);
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"User input {i+1}: {userInputDictionary[i]}");
            }
        }
    }
}
