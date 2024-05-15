using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2); // Hide 2 words at a time
            Console.Clear();
        }
    }
}