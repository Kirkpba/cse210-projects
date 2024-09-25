using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {   
        //We create a new list called numbersList.//
        List<int> numbersList = new List<int>();

        //Seting while loop to go until user enters 0.//
        int newNumber = -3;
        while (newNumber != 0)
        {
            //Asks for a number to be added and adds it to the list unless it is 0.//
            Console.WriteLine("Enter a number to add, (0 to quit)");
            string entry = Console.ReadLine();
            newNumber = int.Parse(entry);

            if (newNumber != 0)
            {
                numbersList.Add(newNumber);
            }

        } 

        //For loop that goes through each number in the list and adds them together.//
        int total = 0;
        foreach (int x in numbersList)
        {
            total += x;
        }

        Console.WriteLine($"The total is {total}");

        //simple calculation that finds the average.//
        float avg = ((float)total) / numbersList.Count;

        Console.WriteLine($"The average is {avg}");

        //Sets the first number in the list as the largest to then go through the list
        //to find the next largest if there is one.
        int largest = numbersList[0];

        foreach (int y in numbersList)
        {
            if (y > largest)
            {
                largest = y;
            }
        }

        Console.WriteLine($"The largest number is {largest}.");
    }
}