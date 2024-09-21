using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        //Parent Variables for use within if statements below.//
        bool passedClass = false;
        string letterGrade = "";

        //Asks user for grade percentage than converts it to an int.//
        Console.WriteLine("What is your grade percentage?");
        string usersGrade = Console.ReadLine();
        int gradePercentage = int.Parse(usersGrade);

        //If, else if, and else statments that see if the gradePercentage is above the 
        //required grade for each letter. Inside each the parent variables from above are
        //changed to reflect their new value based on the grade.//
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
            passedClass = true;
        }

        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
            passedClass = true;
        }

        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
            passedClass = true;
        }

        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
            passedClass = false;
        }

        else
        {
            letterGrade = "F";
            passedClass = false;
        }

        //Prints the letter grade once.//
        Console.WriteLine($"You got an {letterGrade}.");

        //Another if, else if statments to see if the student passed and prints feedback.//
        if (passedClass == true)
        {
            Console.WriteLine("Congrats on passing the class!");
        }

        else if (passedClass != true)
        {
            Console.WriteLine("Great attempt, study hard and see you next semester.");
        }

        
    }
}