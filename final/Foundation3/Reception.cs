public class Reception : Event 
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, string address, string rsvp) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvp;
    }

    public override string FullDetails()
    {
        base.FullDetails();

        Console.WriteLine($"This is a Reception event. Please RSVP to {_rsvpEmail}.");
        return $"This is a Reception event. Please RSVP to {_rsvpEmail}.";
    }

    public override string ShortDescription()
    {
        Console.WriteLine($"Reception Event: {GetTitle()} on {GetDate()}");

        return $"Reception Event: {GetTitle()} on {GetDate()}";
    }
}