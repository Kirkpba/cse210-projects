// Listing Activity Class Code.
class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> //List for prompts to ask the user.
    {
       "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "Who are your personal heroes?",
    };

    //ListingActivity Class inherits from the base Activity class and gives a name and description for the activity. Constructor.
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on positivity by listing items.")
    {

    }

    //Method that calls all the other methods to perform the ListingActivity.
    public override void PerformActivity()
    {
        StartActivity();
        ShowListingPrompt();
        ListItems();
        EndActivity();
    }

    private void ShowListingPrompt() //Method that shows a random prompt to the user to think about.
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("Think about this prompt: ");
        Console.WriteLine(prompt);
        ShowPauseAnimation(8); //Gives them time to think.
    }

    //Method that keeps track of time the user entered and will end when time runs out.
    //Method asks user for answers to the prompt and keeps track of the # of items entered.
    private void ListItems() 
    {
        List<string> items = new List<string>();
        int endTime = Environment.TickCount + (_duration * 1000); //Keeps track of time in seconds.

        while (Environment.TickCount < endTime)
        {
            Console.Write("Entry:> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items.");
    }
}