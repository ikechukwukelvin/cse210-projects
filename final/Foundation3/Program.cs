using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak Blvd", "Austin", "TX", "USA");

        // Create events
        Event lecture = new Lecture("C# Basics", "Introduction to C# programming", DateTime.Now.AddDays(10), "10:00 AM", address1, "John Doe", 100);
        Event reception = new Reception("Networking Event", "An opportunity to network with professionals", DateTime.Now.AddDays(20), "6:00 PM", address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day out with the community", DateTime.Now.AddDays(30), "11:00 AM", address3, "Sunny");

        // Store events in a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Display event details
        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(); // Blank line for better readability
        }
    }
}
