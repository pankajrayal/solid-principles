using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();
            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGeneration.CreateAccount(user);


            StandardMessages.EndApplication();
        }
    }
}
