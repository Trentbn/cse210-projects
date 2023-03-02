public class ListingActivity : Activity
{
    // ATTRIBUTES //
    private List<string> _prompts = new List<string>();

    // METHODS //
    public void RunActivity()
    {
        Random random = new Random();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"-- {_prompts[random.Next(0, _prompts.Count)]} --");
        Console.WriteLine("");
        Thread.Sleep(4000);

        Console.Write("You may begin in:");
        PauseCountdown(3);

        List<string> entries = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write(">");
        
            string entry = Console.ReadLine();
            entries.Add(entry);
        }
        Console.WriteLine($"You listed {entries.Count} items");
        

    }

    // CONSTRUCTORS //
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }
    
}