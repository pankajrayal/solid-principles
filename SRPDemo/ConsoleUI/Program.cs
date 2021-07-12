using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");

            // Ask for User Information
            Person user = new Person();

            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();

            // Checks to be sure the first and last names are valid 
            if (string.IsNullOrWhiteSpace(user.FirstName)) {
                Console.WriteLine("You did not give us a valid first name!");
                Console.ReadLine();
                return;
            }

            if(string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                Console.ReadLine();
                return;
            }

            // Create a username for the person
            string username = user.FirstName.Substring(0, 1).ToLower() + user.LastName.ToLower();

            Console.WriteLine($"Here is the username for {user.FirstName} {user.LastName}");
            Console.WriteLine($"username: {username}");

            Console.ReadLine();
        }
    }
}
