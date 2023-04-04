using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, @"^[a-zA-Z0-9]+([._+\-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine("Valid email entered.");
            }
            else
            {
                Console.WriteLine("Invalid email entered.");
            }
        }
    }
}
