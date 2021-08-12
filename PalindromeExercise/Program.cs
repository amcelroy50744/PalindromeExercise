using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a word lets see if it is a Palindrome");
            var userInput = Console.ReadLine();
            var userWord = new WordSmith();
            var palindrome = userWord.IsAPaldrome(userInput);
            if (palindrome == true)
            {
                Console.WriteLine($"{userInput} is palindrome!");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a palindrome!");
            }

            Console.ReadLine();
        }
    }
}
