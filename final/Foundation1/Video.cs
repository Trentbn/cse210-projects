public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> comments = new List<Comment>();
    
    public int TotalComments()
    {
        return comments.Count();
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine("Video Info:");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {TotalComments()}");
        Console.WriteLine("");

        Console.WriteLine("Comments:");
        
        foreach (Comment comment in comments)
        {
            comment.Display();
        }
    }
    

}