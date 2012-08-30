using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion3SvarOvningar.ExtensionMethods;

namespace Lektion3SvarOvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metoden ligger i ExtensionMethods/ExtensionMethods.cs

            // In returnerar true ifall objektet det anropas på finns i listan
            // som används som in-parameter till In

            int[] intList = { 1, 4, 6, 8 };
            Print(4.In(intList).ToString()); // true

            List<int> intList2 = new List<int> { 6, 8, 0, 3 };
            int i = 7;
            Print(i.In(intList2.ToArray()).ToString()); // false

            string str = "test";
            Print(str.In("hej", "test", "jah").ToString()); // true






            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
