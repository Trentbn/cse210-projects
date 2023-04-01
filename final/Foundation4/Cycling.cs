public class Cycling : Activity{
    double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        double distance = _speed * GetLength() / 60;
        return distance;
    }

    public override double Speed()
    {
        return _speed;
    }
}