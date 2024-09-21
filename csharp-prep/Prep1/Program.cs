using System;

class Program
{
    static void Main(string[] args)
    {   //Ask and get first name.//
        Console.WriteLine("Hello! What is your first name?");
        string firstName = Console.ReadLine();

        //Ask and get last name addresing by first name.//
        Console.WriteLine($"What is your last name {firstName}?");
        string lastName = Console.ReadLine();

        Console.WriteLine(); //Blank Line for spacing.//

        //Writes back their last name, first name, lastname.//
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}