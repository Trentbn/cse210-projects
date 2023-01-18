using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2022;
        job1._endYear = 2023;

        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Sony";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job2.Display();

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        Console.WriteLine($"Company of job1: {resume._jobs[0]._company}");
        resume.Display();
    }
}