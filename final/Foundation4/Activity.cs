public abstract class Activity
{
    private string _date;
    private double _length;

    public double GetLength()
    {
        return _length;
    }

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double Distance();

    public virtual double Speed()
    {
        double speed = Distance() / _length * 60;
        return speed;
    }

    public double Pace()
    {
        double pace = _length / Distance();
        return pace;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {GetType()} ({_length} min) - Distance {Distance()} miles, Speed {Speed()} mph, Pace {Pace()} min per mile");
    }
}