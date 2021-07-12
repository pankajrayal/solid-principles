using OCPLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Udit", LastName = "Bhandari" },
                new PersonModel { FirstName = "Rajeev", LastName = "Singh" },
                new PersonModel { FirstName = "Himanshu", LastName = "Sharma" },
                new PersonModel { FirstName = "Pramod", LastName = "Singh" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach(var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
