using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager activityManager = new ActivityManager();

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Custom Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    activityManager.StartActivity(new BreathingActivity());
                    break;
                case "2":
                    activityManager.StartActivity(new ReflectionActivity());
                    break;
                case "3":
                    activityManager.StartActivity(new ListingActivity());
                    break;
                case "4":
                    activityManager.StartActivity(new CustomActivity());
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
