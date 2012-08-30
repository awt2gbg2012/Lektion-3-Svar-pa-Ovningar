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
            var allUsers = (new Repository()).GetUsers();
            var allPosts = (new Repository()).GetPosts();

            var postedByAdmins = from p in allPosts
                                 join u in allUsers on p.CreatedByID equals u.UserID
                                 where u.Type == Model.User.UserType.Admin
                                 select p;



            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
