public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (_amountComplete < _target)
        {
            _amountComplete++;
            if (_amountComplete == _target)
            {
                _points += _bonus;
                _isComplete = true;
            }
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Points: {_points} - Progress: {_amountComplete}/{_target} - Complete: {IsComplete()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_amountComplete},{_target},{_bonus},{_isComplete}";
    }
}
