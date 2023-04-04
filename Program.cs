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
            Console.WriteLine("Please enter your mobile number:");
            string mobileNumber = Console.ReadLine();

            if (Regex.IsMatch(mobileNumber, @"^91\s[1-9][0-9]{9}$"))
            {
                Console.WriteLine("Valid mobile number entered.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number entered.");
            }

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();


            if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$"))
            {
                Console.WriteLine("Valid password entered.");
            }
            else
            {
                Console.WriteLine("Invalid password entered.");
            }


           
        }
    }
}
