using System;

class Program
{   
    //This is our main function where all other functions return to.//
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    //displays the welcome message.//
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //Asks for their name and returns it to be stored in the main.//
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        return name;
    }

    //Asks for a number and converts it to an int to be returned to the main.//
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string numberText = Console.ReadLine();
        int number = int.Parse(numberText);

        return number;
    }

    //This function takes in the stored number in the main from the prompt number function
    //and squares it to be returned to main.
    static int SquareNumber(int number)
    {
        int squared = number * number;

        return squared;
    }

    //This function takes in the name asked for in the prompt name function and the squared
    //number function to be writen as one line.
    static void DisplayResult(string name, int squarenum)
    {
        Console.WriteLine($"{name}, your number squared is {squarenum}");
    }


}