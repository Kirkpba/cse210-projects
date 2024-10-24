using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();  //Create an instance of ScriptureLibrary
        Scripture selectedScripture = library.GetRandomScripture();  //Get a random scripture from the library

        //Main program loop that keeps displaying scripture and hiding words until all words are hidden or user quits
        while (true)
        {
            Console.Clear(); //Clear the console for each iteration
            selectedScripture.DisplayScripture(); //Display the current state of the scripture (with some words hidden)
            
            //Check if all words are hidden if they are end the program
            if (selectedScripture.AllWordsHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words have been hidden. Goodbye!");
                break;
            }

            // Prompt the user for input
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide random words, or type 'quit' to exit."); //Enter continues the code.
            string input = Console.ReadLine().ToLower();  //Converts to lower case to prevent case sensitive problems.
            
            if (input == "quit")  //End the program if user types "quit"
                break;

            selectedScripture.HideRandomWords();  //Method to hide a few random words in the scripture
        }
    }
}