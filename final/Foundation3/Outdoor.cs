public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        base.FullDetails();

        Console.WriteLine($"This is an Outdoor event. The forecasted weather is {_weather}.");
        return $"This is an Outdoor event. The forecasted weather is {_weather}.";
    }

    public override string ShortDescription()
    {
        Console.WriteLine($"Outdoor Event: {GetTitle()} on {GetDate()}.");

        return $"Outdoor Event: {GetTitle()} on {GetDate()}.";
    }
}