// Main application class code.
public class MindfulnessApp
{
    private BreathingActivity _breathing;
    private ReflectionActivity _reflection;
    private ListingActivity _listing;
    private ThankfulActivity _thankful;

    public MindfulnessApp() //Constructor for the mindfulness app.
    {
        _breathing = new BreathingActivity();
        _reflection = new ReflectionActivity();
        _listing = new ListingActivity();
        _thankful = new ThankfulActivity();
    }

    public void StartApp() //Will start the app and display the menu.
    {
        bool running = true;
        while (running) //While loop that will run until running is false (when user selects option 4.)
    {
        ShowMenu();
        Console.Write("Choose an activity (1-5): ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            _breathing.PerformActivity(); //Once selected start the BreathingActivity class.
        }
        else if (choice == "2")
        {
            _reflection.PerformActivity(); //Once selected start the ReflectionActivity class.
        }
        else if (choice == "3")
        {
            _listing.PerformActivity(); //Once selected start the ListingActivity class.
        }
        else if (choice == "4")
        {
            _thankful.PerformActivity(); //Once selected start the ThankfulActivity class.
        }
        else if (choice == "5")
        {
            Console.WriteLine("Exiting the app. Thank you for using MindfulnessApp!");
            running = false; //Break the while loop and end the program.
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
        }
    }
}

    private void ShowMenu() //Simple function to display the menu. Makes reading the while loop easier.
    {
        Console.WriteLine();
        Console.WriteLine("--Mindfulness App Menu--");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Thankful Activity");
        Console.WriteLine("5. Exit");
        Console.WriteLine();
    }
}