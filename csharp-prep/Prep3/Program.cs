using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   
        //RandomGenerator creates a new random number to be guessed.//
        Random RandomGenerator = new Random();
        int number = RandomGenerator.Next(1,101);

        Console.WriteLine("Welcome to Guess the Number!");

        //Set number to get the while loop to work. Also placeholder int.//
        int numberGuess = -3;

        //While loop that will run untill the number the user guessed = the random number.//
        while (numberGuess != number)
        {
            //Gets that random number and makes sure it is an integer.//
            Console.WriteLine("Please enter your guess for the number (1-100)");
            string guess = Console.ReadLine();
            numberGuess = int.Parse(guess);

            //Self explanatory if the random number is higher than guess than say higher.//
            if (number > numberGuess)
            {
                Console.WriteLine("Higher");
            }
            //Ditto but for lower.//
            else if (number < numberGuess)
            {
                Console.WriteLine("Lower");
            }
            //If the number guessed = random number the user guessed it!//
            else
            {
                Console.WriteLine($"You guessed it! The number is {number}");
            }


        }


    }
}