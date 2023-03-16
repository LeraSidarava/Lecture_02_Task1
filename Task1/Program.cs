using System;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            // A string input
            Console.WriteLine("Enter a line can not be empty: ");
            string userInput = Console.ReadLine();


            // Replace any non-alphanumeric characters and case-sensitivity in the input string
            userInput = userInput.ToLower().Replace("[^a-z]", "");

            // If you want to use not only alphabetical symbols but also numbers
            // userInput = userInput.ToLower().Replace("[^a-z,0-9]", "");

            // Check if the input is a palindrome
            string newInput = new string(userInput.Reverse().ToArray());

            if (userInput == newInput)
            {
                Console.WriteLine("This is a palindrome.");
            }
            else
            {
                Console.WriteLine("This is not a palindrome.");
            }
        }
    }
}

