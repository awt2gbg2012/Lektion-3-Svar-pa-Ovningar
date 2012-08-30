using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion3SvarOvningar.ExtensionMethods;
using Lektion3SvarOvningar.Model.Repository;
using Lektion3SvarOvningar.Model;

namespace Lektion3SvarOvningar
{
    class Program
    {
        static void Main(string[] args)
        {
            var allUsers = (new Repository()).GetUsers();
            var allPosts = (new Repository()).GetPosts();

            var averageLengthForFullName = allUsers.Average(u => u.FullName.Length);
            Print(averageLengthForFullName.ToString());



            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
