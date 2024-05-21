public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never complete, but you get points each time you record an event
    }

    public override string GetDetailsString()
    {
        return $"[ ∞ ] {Name} - {Points} points (Eternal)";
    }
}
