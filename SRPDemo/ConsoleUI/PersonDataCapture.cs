﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            // Ask for User Information
            Person output = new Person();

            Console.WriteLine("What is your first name: ");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}