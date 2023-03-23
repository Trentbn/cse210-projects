public class Comment
{
    public string _name;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"{_comment} - {_name}");
    }
}