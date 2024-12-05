using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running(new DateTime(2024, 12, 1), 30, 4.8); // 4.8 km
        Activity cycling = new Cycling(new DateTime(2024, 12, 2), 45, 20); // 20 kph
        Activity swimming = new Swimming(new DateTime(2024, 12, 3), 25, 40); // 40 laps

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries for each activity
        Console.WriteLine();
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}