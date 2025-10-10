public abstract class Goal
{
    private string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract int RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}