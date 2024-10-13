using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        int numOpt = -1;

        while (numOpt != 5) //Display for user options
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to your digital Journal!");
            Console.WriteLine("1.) Write an entry");
            Console.WriteLine("2.) Display your entries");
            Console.WriteLine("3.) Save current entries to new file");
            Console.WriteLine("4.) Load a file of entries");
            Console.WriteLine("5.) Quit program");
            Console.WriteLine("Pick an option: ");

            //Reads users answer and changes to int to be read for the if else statements.
            string opt = Console.ReadLine();
            numOpt = int.Parse(opt);
            Console.WriteLine();

            if (numOpt == 1)
            {
                // Write a new entry
                Console.WriteLine("Writing a new entry...");

                PromptManager promptManager = new PromptManager();

                string prompt = promptManager.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                // Prompt the user for response and save it to journal entries
                Console.Write("Enter response: ");
                string response = Console.ReadLine();
                Console.Write("Enter date (YYYY-MM-DD): ");
                string date = Console.ReadLine();
                Console.Write("Enter today's lucky number:");
                string luckyNumber = Console.ReadLine();
                
                newJournal.AddEntry(prompt, response, date, luckyNumber);
            }

            else if (numOpt == 2)
            {
                // Displays this sessions journal
                Console.WriteLine("Displaying the journal...");
                newJournal.DisplayJournal();
            }

            else if (numOpt == 3)
            {
                // Save the journal entries to a file
                Console.Write("Enter filename to save (Include .txt extension): ");
                string saveFilename = Console.ReadLine();
                newJournal.SaveToFile(saveFilename);
                Console.WriteLine("Journal saved to file.");
            }

            else if (numOpt == 4)
            {
                // Load the journal entries from a file
                Console.Write("Enter filename to load (Include .txt extension): ");
                string loadFilename = Console.ReadLine();
                newJournal.LoadFromFile(loadFilename);
                Console.WriteLine("Journal loaded from file.");
                Console.WriteLine("Displaying the loaded journal...");
                newJournal.DisplayJournal();
            }

            else if (numOpt == 5) //Exits the loop and ends the program.
            {
                Console.WriteLine("Exiting Journal program");
            }

            else //Stays in the loop and asks for correct choice.
            {
                Console.WriteLine("Please enter an appropriate option.");
            }
        }      
    }
}

//Design portion - Ended up being way different.
//Class: Program
    //Responsibilities: The main program class will display a main menu
        //with options to select from. Write,Display,Load,Save,and Quit.
    //Attributes: _option:int
    //Behaviors: Uses a While Loop to run through the options and go
        //to the class/option the user entered. Will also "host" each
        //class to use to complete the program.
	    // Display(Menu):void

//Class: Write
    //Responsibilities: This class will contain a list of prompts that will
        //be randomly selected and then displayed for the user to answer. It
        //will also be where the user enters their data that will be stored in
        //variables.
    //Attributes: _prompts:List<prompt>;
                //_entry:string;
    //Behaviors: Display(Random._prompts):void

//Class: Display
    //Responsibilities: This class will take the saved entries and diplay 
        //them along with the date and prompts.
    //Attributes: _entries:List<entry>;
    //Behaviors: Display():void;

//Class: Save to File
    //Responsibilities: This class will contain a method to save the enterd
        //data into a CSV or txt file for external use.
    //Attributes: _createNewFile():string;
    //Behaviors: _SavetoCSV("Filename.txt");
               //_ConvertStringToFile("Filename.txt");

//Class: Load a File
    //Responsibilities: This class will contain a method to load a CSV file 
        //into the Journal program to display.
    //Attributes: _loadedFile():string;
    //Behaviors: _LoadaCSV("Filename.txt");
               //_ConvertFileToString("Filename.txt");

