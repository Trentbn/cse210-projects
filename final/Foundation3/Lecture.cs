public class Lecture : Event 
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    
    public override string FullDetails()
    {
        base.FullDetails();

        Console.WriteLine($"This is a Lecture event. The speaker will be {_speaker}. There will be a limited capacity of {_capacity} people");
        return $"This is a Lecture event. The speaker will be {_speaker}. There will be a limited capacity of {_capacity} people";
    }

    public override string ShortDescription()
    {
        Console.WriteLine($"Lecture Event: {GetTitle()} on {GetDate()}");
        
        return$"Lecture Event: {GetTitle()} on {GetDate()}";
    }
}