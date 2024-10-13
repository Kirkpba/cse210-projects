using System.Runtime.CompilerServices;

class Entry
{
    public string _prompt;
    public string _response;
    public string _date;
    public string _luckyNumber;

    //Constructor to hold information in class
    public Entry(string prompt, string response, string date, string luckyNumber)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
        _luckyNumber = luckyNumber;
    }

    //Method to display the entries for the journal
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Lucky Number: {_luckyNumber}");
    }
}