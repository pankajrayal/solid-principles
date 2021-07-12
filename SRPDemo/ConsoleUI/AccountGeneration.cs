using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AccountGeneration
    {
        public static void CreateAccount(Person user)
        {
            // Create a username for the person
            string username = user.FirstName.Substring(0, 1).ToLower() + user.LastName.ToLower();

            Console.WriteLine($"Here is the username for {user.FirstName} {user.LastName}");
            Console.WriteLine($"username: {username}");
        }
    }
}
