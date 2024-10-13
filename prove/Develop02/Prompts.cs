public class PromptManager
{
    public List<string> _prompts; //Creates a new list to host prompts
    public Random _random; //Random to select random prompt from list

    public PromptManager() //Constructor
    {
        _prompts = new List<string>
        {
            "What are your goals did you accomplish today?",
            "What homework did you work on today?",
            "What was a surprise that happand today?",
            "What was your favorite scripture you found today?",
            "Guess what exciting thing might happen tommorow."
        };

        _random = new Random();
    }

    public string GetRandomPrompt() //Method to get a random prompt
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }


}