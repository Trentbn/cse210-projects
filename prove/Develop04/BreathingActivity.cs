public class BreathingActivity : Activity 
{
    // METHODS //
    public void RunActivity()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breath in...");
            PauseCountdown(4);

            Console.WriteLine("");
            Console.Write("Now breath out...");
            PauseCountdown(4);

            Console.WriteLine("");
            Console.Write("Breath in...");
            PauseCountdown(4);

            Console.WriteLine("");
            Console.Write("Now breath out...");
            PauseCountdown(4);
        }
        


    }

    // CONSTRUCTORS //
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }
}