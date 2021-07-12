﻿using OCPLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Udit", LastName = "Bhandari" },
                new ManagerModel { FirstName = "Rajeev", LastName = "Singh"},
                new ExecutiveModel { FirstName = "Himanshu", LastName = "Sharma" },
                new PersonModel { FirstName = "Pramod", LastName = "Singh"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach(var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager: {emp.IsManager}, IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
