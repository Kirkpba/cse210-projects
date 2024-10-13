// Define the Journal class to manage journal entries
class Journal
{
    //atributes
    private List<Entry> _entries;

    // Constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Method to add a new entry
    public void AddEntry(string prompt, string response, string date, string luckyNumber)
    {
        _entries.Add(new Entry(prompt, response, date, luckyNumber));
    }

    // Method to display all entries
    public void DisplayJournal()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    // Method to save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}|{entry._luckyNumber}");
            }
        }
    }

    // Method to load journal from a file
    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clear existing _entries before loading from file
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    AddEntry(parts[1], parts[2], parts[0], parts[3]);
                }
            }
        }
    }
}