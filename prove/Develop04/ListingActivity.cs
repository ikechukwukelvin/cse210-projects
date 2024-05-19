class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void PerformActivity()
    {
        Console.WriteLine("Starting listing activity...");
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        Console.WriteLine("Start listing...");
        Thread.Sleep(Duration * 1000);

        Console.WriteLine($"You listed for {Duration} seconds.");
    }
}