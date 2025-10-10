public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonusPoints = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed) 
        : base(name, description, points)
    {
        _amountCompleted = completed;
        _target = target;
        _bonusPoints = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int pointsEarned = _points;

            if (_amountCompleted == _target)
            {
                pointsEarned += _bonusPoints;
            }
            return pointsEarned;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        string status = _amountCompleted >= _target ? "[X]" : "[ ]";
        
        return $"{status} {GetName()} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{_description}|{_points}|{_target}|{_bonusPoints}|{_amountCompleted}";
    }
}