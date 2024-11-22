using System.Diagnostics;

class EternalQuestApp
{
    private List<Goal> _goals;
    private int _userScore;
    private string _fileName;

    public EternalQuestApp()
    {
        _goals = new List<Goal>();
        _userScore = 0;
        _fileName = "goals_file.txt";
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("--- Eternal Quest ---");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                CreateGoal();
            else if (choice == "2")
                RecordEvent();
            else if (choice == "3")
                DisplayGoals();
            else if (choice == "4")
                DisplayScore();
            else if (choice == "5")
                SaveGoals();
            else if (choice == "6")
                LoadGoals();
            else if (choice == "7")
                break;
            else
                Console.WriteLine("Invalid option. Try again.");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Exponential Goal");
        Console.Write("Your choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
        }
        else if (type == "4")
    {
        Console.Write("Enter target count: ");
        int targetCount = int.Parse(Console.ReadLine());
        _goals.Add(new ExponentialGoal(name, points, targetCount));
    }    
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("Choose a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            _goals[goalNumber].RecordEvent(ref _userScore);
            Console.WriteLine("Event recorded!");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    private void DisplayGoals()
    {
        Console.WriteLine();
        Console.WriteLine("--- Goals ---");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal);
        }
    }

    private void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine("--- Score ---");
        Console.WriteLine($"Current score: {_userScore}");
    }

    private void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                writer.WriteLine(_userScore);
                foreach (var goal in _goals)
                {
                    writer.WriteLine($"{goal.GetType().Name}|{goal.Save()}");
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    private void LoadGoals()
    {
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("No saved data found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(_fileName))
            {
                _userScore = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    var goalType = parts[0];
                    var goalData = parts[1];

                    Goal goal = goalType switch
                    {
                        "SimpleGoal" => new SimpleGoal("", 0),
                        "EternalGoal" => new EternalGoal("", 0),
                        "ChecklistGoal" => new ChecklistGoal("", 0, 0, 0),
                        "ExponentialGoal" => new ExponentialGoal("", 0, 0),
                        _ => null
                    };

                    if (goal != null)
                    {
                        goal.Load(goalData);
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Goals loaded successfully.");
            Console.WriteLine();
            Console.WriteLine("~~~ Loaded Data ~~~");
            DisplayGoals();
            DisplayScore();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}