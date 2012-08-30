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
            Func<string, bool> IsLessThan4Chars = s => s.Length < 4;
            var allUsers = (new Repository()).GetUsers();
            var allPosts = (new Repository()).GetPosts();

            var users = from u in allUsers
                        where IsLessThan4Chars(u.FirstName)
                        select u;



            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
