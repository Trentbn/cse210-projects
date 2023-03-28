public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }

    public virtual string StandardDetails()
    {
        Console.WriteLine($"Event: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");

        return $"Event: {_title}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {_address}";
    }

    public virtual string FullDetails()
    {
        Console.WriteLine($"Event: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");

        return $"Event: {_title}, Description: {_description}, Date: {_date}, Time: {_time}, Address: {_address}";
    }

    public abstract string ShortDescription();
}