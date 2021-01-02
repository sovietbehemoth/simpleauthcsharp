using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;

namespace BehemothClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username you would like to use");
            var username = Console.ReadLine();
            Console.WriteLine($"Your username is {username}");
            Console.WriteLine("Enter a password");
            var password = Console.ReadLine();
            Console.WriteLine("Enter your password again to confirm");
            var passwordconfirm = Console.ReadLine();
           
            if (password.Equals(passwordconfirm))
            {
                if (password.Length >= 8)
                {
                    Console.WriteLine($"Welcome {username}");
                }
                else
                {
                    Console.WriteLine("Your password must be longer than 8 characters");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Passwords do not match");
                return;
            }


        }
    }
}
