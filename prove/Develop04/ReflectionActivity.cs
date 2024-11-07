 // Reflection Activity Class Code.
class ReflectionActivity : Activity
{
    private List<string> _availableQuestions; //List for questions not asked for no repetition.
    private List<string> _prompts = new List<string> //List of prompts to ask the user.
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _initialQuestions = new List<string> //List of questions to ask for the prompt.
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    //Inheriting from base class and giving name and description of activity. Constructor.
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times of strength and resilience.")
    {
        //Initialize available questions list for each new session
        _availableQuestions = new List<string>(_initialQuestions);
    }

    public override void PerformActivity()
    {
        StartActivity();
        
        // Display the first prompt and wait for the user to press Enter
        ShowReflectionPrompt();
        Console.WriteLine("Press Enter when you're ready to start reflecting.");
        Console.ReadLine();  // Wait for the user to press Enter
        
        // Now begin showing the questions with a countdown
        int remainingTime = _duration;
        while (remainingTime > 0 && _availableQuestions.Count > 0)
        {
            ShowReflectionQuestion();
            ShowPauseAnimation(10);
            remainingTime -= 10; //Remaining time should always be -= # that is the same for the animation time.
        }
        
        EndActivity();
    }

    //Method that selects a random reflection prompt from the list and displays it.
    private void ShowReflectionPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine("Reflect on this prompt: ");
        Console.WriteLine(prompt);
    }

    // Method that selects a random question, show it, and remove it from available questions list.
    private void ShowReflectionQuestion()
    {
        Random random = new Random();
        int index = random.Next(_availableQuestions.Count);
        string question = _availableQuestions[index];
        _availableQuestions.RemoveAt(index);

        Console.WriteLine(question);
    }
}