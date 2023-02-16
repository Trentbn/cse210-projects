using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Trent Nelson", "CSE210");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Taylor Nelson", "Calculas", "4.3", "5-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Willie Nelson", "English", "Why Skateboarding is Cool");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
    }
}