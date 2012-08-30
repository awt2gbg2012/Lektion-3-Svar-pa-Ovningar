using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion3SvarOvningar.ExtensionMethods;
using Lektion3SvarOvningar.Model.Repository;

namespace Lektion3SvarOvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> myDelegate = s => s.Length < 4;
            Print(myDelegate("asdf").ToString()); // false;
            Print(myDelegate("asd").ToString()); // true;



            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
