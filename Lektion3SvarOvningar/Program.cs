using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion3SvarOvningar.Extension_Methods;

namespace Lektion3SvarOvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Extension-metoden kan hängas på i stort sett vilken typ som helst
            // och returnerar true ifall objektet finns i lista som skickas med.

            // Jag har definierat metoden i Extension Methods/ExtensionMethods.cs

            int[] intList = new int[] { 3, 5, 6, 7, 8 };

            // Print definieras nedan
            Print(1.In(intList).ToString()); // false
            int i = 6;
            Print(6.In(intList).ToString()); // true

            Print("hej".In("hej2", "hej3", "hej").ToString()); // true

            Console.ReadLine();
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
