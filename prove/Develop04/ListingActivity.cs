public class ListingActivity : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have a few seconds to think about the prompt...");
        ShowSpinner(3);

        Console.WriteLine("Start listing items:");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
    }
}
