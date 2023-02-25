public class Activity 
{
    // ATTRIBUTES //
    private string _name;
    private string _description;
    private int _duration;

    // GETTER/SETTERS //
    public int GetDuration(){
        return _duration;
    }

    // METHODS //
    public void  DisplayStartMessage(){
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine("");

        Console.WriteLine(_description);
        Console.WriteLine("");

        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());

        _duration = duration;

        Console.Clear();

        Console.WriteLine("Get ready...");

    }
    public void DisplayEndMessage(){
        Console.WriteLine("Well done!");
        PauseSpinner(3);

        Console.WriteLine("");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        PauseSpinner(5);
    }
    public void PauseSpinner(int duration){
       //  Console.WriteLine("Get Ready...");

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {

            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        
        }
        //    Thread.Sleep(5000);
    }
    public void PauseCountdown(int count)
    {
        for (int i = count; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // CONSTRUCTORS //
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

}