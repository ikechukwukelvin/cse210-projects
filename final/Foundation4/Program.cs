using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2022, 11, 3), 30, 12.0);
        Activity swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);

        // Store activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(); // Blank line for better readability
        }
    }
}
