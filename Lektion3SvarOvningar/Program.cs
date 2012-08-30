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
            var Repo = new Repository(); 
            var allUsers = Repo.GetUsers();
            var allPosts = Repo.GetPosts();

            var datePostGroups = allPosts.OrderBy(p => p.CreateDate).GroupBy(p => p.CreateDate.Date);
            foreach (var group in datePostGroups)
            {
                Print(group.Key.ToShortDateString() + ":");
                foreach (var post in group)
                {
                    Print("\t" + post.ToString());
                }
            }

            Console.ReadLine();
        }

        // Hjälpmetod för att kunna snabba på då jag vill skriva ut ngt till konsolen
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
