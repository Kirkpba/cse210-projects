class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Pine St", "Denver", "CO", "USA");

        // Create events
        Lecture lecture = new Lecture("Tech Talk", "A talk on emerging technologies", "2024-12-10", "10:00 AM", address1, "Dr. Smith", 100);
        Reception reception = new Reception("Networking Night", "An evening of professional networking", "2024-12-12", "7:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "A picnic in the park for the community", "2024-12-15", "12:00 PM", address3, "Sunny, 75°F");

        // Add events to a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };
        
        // Display event details
        foreach (var eventItem in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(eventItem.GetStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(eventItem.GetShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}