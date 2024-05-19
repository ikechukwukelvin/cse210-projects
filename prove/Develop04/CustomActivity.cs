class CustomActivity : Activity
{
    public CustomActivity()
    {
        Name = "Custom";
        Description = "This is a custom activity that you can define yourself.";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Starting custom activity...");
        // Add your custom activity logic here
        Thread.Sleep(Duration * 1000);
    }
}
