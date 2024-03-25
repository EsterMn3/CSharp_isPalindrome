using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        do
        {
            Console.WriteLine("Palindrome Checker");
            Console.WriteLine("Enter a word or phrase:");

            string input = Console.ReadLine();

            // Check if the input is a palindrome
            bool isPalindrome = IsPalindrome(input);

            // Display the result
            Console.WriteLine($"'{input}' is {(isPalindrome ? "a palindrome" : "not a palindrome")}");

            // Ask if the user wants to enter another word
            Console.WriteLine("Do you want to enter another word? Type 'yes' or any other word for 'no'");
            
            userInput = Console.ReadLine().Trim().ToLower();
        } while (userInput.StartsWith("y"));
    }

    // Method to check if a string is a palindrome
    static bool IsPalindrome(string input)
    {
        // Convert the input to lowercase and remove non-alphanumeric characters
        string cleanInput = RemoveNonAlphanumeric(input.ToLower());

        // Initialize pointers at the beginning and end of the cleaned input
        int start = 0;
        int end = cleanInput.Length - 1;

        // Continue comparing characters until the pointers meet in the middle
        while (start < end)
        {
            if (cleanInput[start] != cleanInput[end])
            {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }

    // Method to remove non-alphanumeric characters from a string
    static string RemoveNonAlphanumeric(string input)
    {
        // Define a character array of valid characters
        char[] validChars = input.ToCharArray();

        // Iterate through the characters and remove non-alphanumeric characters
        for (int i = 0; i < validChars.Length; i++)
        {
            if (!char.IsLetterOrDigit(validChars[i]))
            {
                validChars[i] = ' ';
            }
        }

        // Return the cleaned string
        return new string(validChars);
    }
}
