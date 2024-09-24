using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Addition Calculator");

        Console.WriteLine();

        Console.WriteLine("What is your first number?");

        string firstString = Console.ReadLine();
        int firstNumber = int.Parse(firstString);

        Console.WriteLine("What is your second number?");

        string secondString = Console.ReadLine();
        int secondNumber = int.Parse(secondString);

        int total = firstNumber + secondNumber;

        Console.WriteLine();

        Console.WriteLine($"The answer for, {firstNumber} + {secondNumber} = {total}");
    }
}