// Base Activity class
public abstract class Activity //Abstracted so not used by itself without being inherited.
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity(string name, string description) //Constructor for Activity class
    {
        _name = name;
        _description = description;
    }

    public void StartActivity() //Start Activity Method that finds the activity name and description 
    //from the inherited class. Also asks for duration and includes the Pause animation.
    {
        Console.WriteLine();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowPauseAnimation(3);
    }

    public void EndActivity() //End Activity Method that gives some text for the user and boots back to menu.
    {
        Console.WriteLine();
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"Activity: {_name}, Duration: {_duration} seconds");
        ShowPauseAnimation(3);
        
    }

    //The ShowPauseAnimation will display a countdown animation that replaces over itself. The duration is 
    //determined by what is entered into the ShowPauseAnimation Method when called.
    protected void ShowPauseAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rPausing... {i} seconds ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void PerformActivity(); //PerformActivity Method that can be called to overide in the 
    //child classes and used within the MindfulnessApp Class.
}