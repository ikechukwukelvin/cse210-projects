using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        while (true)
        {
            Console.WriteLine("1. Display goals\n2. Create goal\n3. Record event\n4. Display score\n5. Save goals\n6. Load goals\n7. Quit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.ListGoalDetails();
                    break;
                case "2":
                    goalManager.CreateGoal();
                    break;
                case "3":
                    goalManager.RecordEvent();
                    break;
                case "4":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    goalManager.SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
