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

            Print(1.Between(0, 4).ToString()); // true

            int i = 7;
            Print(i.Between(2,5).ToString()); // false

            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
