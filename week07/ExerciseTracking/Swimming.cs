public class Swimming : Activity
{
    private int _laps; 

    private const double METERS_PER_LAP = 50.0;
    private const double METERS_PER_MILE = 1609.34;

    public Swimming(string date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double meters = (double)_laps * METERS_PER_LAP;
        return meters / METERS_PER_MILE;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }
}