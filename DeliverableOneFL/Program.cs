using System;
using System.Linq;
namespace DeliverableOneFL
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 7;
            int maxLength = 12;

            Console.WriteLine("Enter a password:");
            string userInput = Console.ReadLine();
            int passwordLength = userInput.Length;

            if (passwordLength >= minLength && passwordLength <= maxLength && userInput.Contains("!") && userInput.Any(char.IsUpper)
                && userInput.Any(char.IsLower) && userInput.Any(char.IsDigit))
            {

                Console.WriteLine("Password Valid And Accepted.");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
