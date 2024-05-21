using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Example goals
        goalManager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend temple", 50, 10, 500));

        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display goals");
            Console.WriteLine("2. Add goal");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    goalManager.DisplayGoals();
                    break;
                case "2":
                    // Implement Add Goal functionality
                    break;
                case "3":
                    Console.WriteLine("Enter the name of the goal to record:");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
                    break;
                case "4":
                    goalManager.DisplayScore();
                    break;
                case "5":
                    // Implement Save functionality
                    break;
                case "6":
                    // Implement Load functionality
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
