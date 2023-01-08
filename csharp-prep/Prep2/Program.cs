using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage?");
        string userGradePercent = Console.ReadLine();
        int gradeInt = int.Parse(userGradePercent);
        
        string letterGrade = " ";

        if (gradeInt > 89)
        {
            letterGrade = "A";
        }
        else if (gradeInt > 79)
        {
            letterGrade = "B";
        }
        else if (gradeInt > 69)
        {
            letterGrade = "C";
        }
        else if (gradeInt > 59)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is {letterGrade}");

        if (gradeInt > 69)
        {
            Console.WriteLine("You passed the class, great job!");
        }
        else 
        {
            Console.WriteLine("You didn't pass the class, better luck next time!");
        }
    }
}