using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dictionary1 = new Dictionary<string, double>()
            {
                {"Apple", 5.50}, {"Orange", 10.00}, {"Banana", 3.00}
            };
            int i = 0;
            foreach(KeyValuePair<string, double> fruit in dictionary1)
            {
                i += 1;
                Console.WriteLine($"Fruit {i}: {fruit.Key}s are ${fruit.Value} each");
            }
        }
    }
}
