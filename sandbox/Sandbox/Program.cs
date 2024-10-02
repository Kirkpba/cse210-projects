using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
         //We create a new list called numbersList.//
        List<string> groceryList = new List<string>();

        //Seting while loop to go until user enters 0.//
        string entry = "";
        while (entry != "done")
        {
            //Asks for a number to be added and adds it to the list unless it is 0.//
            Console.WriteLine("Please enter your groceries.");
            entry = Console.ReadLine();

            if (entry != "done")
            {
                groceryList.Add(entry);
            }

        } 

        Console.WriteLine();
        
        int totalItems = groceryList.Count;

        Console.WriteLine($"Grocery List ({totalItems} items)");

        foreach(string i in groceryList)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine();

        //Get user input and print it out//
        Console.WriteLine("What is your comment?");
        string commet = Console.ReadLine();
        Console.WriteLine($"Your comment is: {commet}");
        Console.WriteLine();

        List<string> animalList = new List<string>();
        animalList.Add("Goat");
        animalList.Add("Sheep");
        animalList.Add("Cow");

        Console.WriteLine("Animals");
        foreach (string i in animalList)
        {
            Console.WriteLine(i);
        }

    }
}
