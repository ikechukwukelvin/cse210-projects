public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                IsComplete = true;
            }
        }
    }

    public override string GetDetailsString()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} - {Points} points, Completed {CurrentCount}/{TargetCount} times, Bonus: {BonusPoints} points";
    }
}
