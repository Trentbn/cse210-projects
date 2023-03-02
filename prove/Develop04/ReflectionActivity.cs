public class ReflectionActivity : Activity
{
    // ATTRIBUTES //
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // METHODS //
    public void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        Random rnd = new Random();

        Console.WriteLine($"-- Consider a time when you {_prompts[rnd.Next(0, _prompts.Count)]} --");
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        
        string userReady = "1";
        userReady = Console.ReadLine();

        if (userReady == "")
        {

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.WriteLine("");
            Thread.Sleep(4000);

            Console.Write("You may begin in: ");
            PauseCountdown(3);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
            Console.WriteLine("");

            Console.WriteLine(_questions[rnd.Next(0, _questions.Count)]);
            PauseSpinner(10);
            Console.WriteLine("");
            }

        }


    }

    // CONSTRUCTORS //
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts.Add("stood up for someone else.");
        _prompts.Add("did something really difficult.");
        _prompts.Add("helped someone in need.");
        _prompts.Add("did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
}