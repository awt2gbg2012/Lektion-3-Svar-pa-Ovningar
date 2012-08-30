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

            var allUsersOfTypeUser = allUsers.Where(u => u.Type == User.UserType.User);
            foreach (var user in allUsersOfTypeUser)
                Print(user.ToString());



            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
