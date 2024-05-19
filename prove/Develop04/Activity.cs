abstract class Activity
{
    protected int Duration { get; set; }
    protected string Name { get; set; }
    protected string Description { get; set; }

    public void Start()
    {
        Console.WriteLine($"Starting {Name} Activity:");
        Console.WriteLine(Description);
        SetDuration();
        PrepareToBegin();
        PerformActivity();
        FinishActivity();
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    protected abstract void PerformActivity();

    protected void FinishActivity()
    {
        Console.WriteLine($"Congratulations! You've completed the {Name} Activity for {Duration} seconds.");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
