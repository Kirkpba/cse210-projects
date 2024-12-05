// Base class for activities
public abstract class Activity
{
    private DateTime _date;

    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes() => _minutes;

    public DateTime GetDate() => _date;

    public virtual double GetDistance() => 0.0;

    public virtual double GetSpeed() => 0.0;

    public virtual double GetPace() => 0.0;
    
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min): Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}