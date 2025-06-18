using System.Runtime.CompilerServices;

namespace Debugging // Namespace declaration for the application
{
    internal class Program // Internal class named Program
    {
        static void Main(string[] args) // Main entry point of the application
        {
            Console.WriteLine("hei");
            Console.WriteLine("Hello, World!"); // Print greeting to the console

            var range = 200; // Define the range for character codes to count
            var counts = new int[range]; // Initialize an array to store character counts
            string text = "something"; // Initialize text variable with a non-empty value
            while(!string.IsNullOrEmpty(text)) // Loop until the input text is empty or null
            {
                text = Console.ReadLine(); // Read a line from the console 
                foreach(var character in text ?? string.Empty) // Iterate over each character in the input text
                {
                    counts[ (int)character]++; // Increment the count for the character's ASCII code
                }
                for(var i=0;i<range;i++) // Loop through all possible character codes in the range
                {
                    DoSomething(counts, i);
                }
            }
        
        

            

        }

        private static void DoSomething(int[] counts, int i)
        
        {
            if (counts[i] > 0) // If the character has occurred at least once
            {
                var character = (char)i; // Convert the index to its corresponding character
                Console.WriteLine((character + " - " + counts[i])); // Print the character and its count
            }
        }
    }
}

