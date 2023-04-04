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
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            if (Regex.IsMatch(firstName, @"^[A-Z][a-z]{2,}$"))
            {
                Console.WriteLine("Valid first name entered.");
            }
            else
            {
                Console.WriteLine("Invalid first name entered.");
            }
        }
    }
}
