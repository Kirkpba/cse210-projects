using System;

class Program
{
    static void Main(string[] args)
    {
        Job joba = new Job();
        joba._jobTitle = "Software Engineer";
        joba._company = "Micron";
        joba._startYear = 2019;
        joba._endYear = 2022;

        Job jobb = new Job();
        jobb._jobTitle = "Janitor";
        jobb._company = "BYU-I";
        jobb._startYear = 2022;
        jobb._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "John Allen";

        myResume._jobs.Add(joba);
        myResume._jobs.Add(jobb);

        myResume.Display();
    }
}