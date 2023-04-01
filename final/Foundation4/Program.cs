using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the exercise program!");
        Console.WriteLine("");

        List<Activity> exercises = new List<Activity>();

        Running running = new Running("12/12/23", 30.00, 3.00);
        exercises.Add(running);

        Cycling cycling = new Cycling("November 3rd, 2023", 60.00, 15.00);
        exercises.Add(cycling);

        Swimming swimming = new Swimming("04 Nov, 2023", 20, 65);
        exercises.Add(swimming);

        foreach (Activity exercise in exercises)
        {
            exercise.GetSummary();
        }

    }
}