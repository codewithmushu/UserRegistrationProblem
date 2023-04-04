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
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            if (Regex.IsMatch(lastName, @"^[A-Z][a-z]{2,}$"))
            {
                Console.WriteLine("Valid last name entered.");
            }
            else
            {
                Console.WriteLine("Invalid last name entered.");
            }
        }
    }
}
