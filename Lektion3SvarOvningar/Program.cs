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
            // Metoden ligger i ExtensionMethods/ExtensionMethods.cs

            var user = (new Repository()).GetUsers().FirstOrDefault();

            Print(user.ToString()); // Detta är .ToString() som ärvs av Object - Det är omöjligt att ersätta denna med en extension method
            Print(user.ToString(true)); // Detta är min ExtensionMethod - jag har lagt till ett extra parameter, nu funkar det




            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
