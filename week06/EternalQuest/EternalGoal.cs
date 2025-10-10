public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetName()} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{_description}|{_points}";
    }
}