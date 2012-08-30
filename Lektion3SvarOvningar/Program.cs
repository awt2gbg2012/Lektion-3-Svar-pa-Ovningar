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
            // Insåg att om jag skapar ett repo för bägge raderna nedan så kommer 
            // användarna ha olika IDs i allPosts och allUsers eftersom datan genereras 
            // om varje gång jag skapa ett repo - är även ett problem för min lösning på 
            // uppgift 6 - använd samma repo för både .GetUsers() och .GetPosts() för 
            // att få ut ett resultat för uppg. 6
            var Repo = new Repository(); 
            var allUsers = Repo.GetUsers();
            var allPosts = Repo.GetPosts();

            var funnyPosts = allPosts.Where(p => p.Tags.Any(t => t == Post.PostTags.Funny));
            var postersOfFunnyTags = allUsers.Where(u => funnyPosts.Any(p => p.CreatedByID == u.UserID));
            foreach (var user in postersOfFunnyTags)
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
