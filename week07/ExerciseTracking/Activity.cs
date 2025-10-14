using System;

public abstract class Activity
{
    protected string _date;
    protected int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance(); 
    public abstract double GetSpeed();    
    public abstract double GetPace();     
    
    protected virtual string GetDistanceUnits() { return "miles"; }
    protected virtual string GetSpeedUnits() { return "mph"; }
    protected virtual string GetPaceUnits() { return "min per mile"; }

    public virtual string GetSummary() 
    {
        string type = GetType().Name; 

        return $"{_date} {type} ({_lengthInMinutes} min): " +
               $"Distance {GetDistance():F2} {GetDistanceUnits()}, " +
               $"Speed {GetSpeed():F2} {GetSpeedUnits()}, " +
               $"Pace {GetPace():F2} {GetPaceUnits()}";
    }
}