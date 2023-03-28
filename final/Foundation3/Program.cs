using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Event program!");
        Console.WriteLine("");

        Address addressObject = new Address("10697 W Centennial Pkwy", "Las Vegas", "NV", "USA");
        string lectureAddress = addressObject.AddressString();
        Lecture lectureEvent = new Lecture("How to Train Your Dog", "Learn how to tame your house dog", "July 12th", "12:30pm", lectureAddress, "Bob Dylan", "300");

        Console.WriteLine("Standard Details:");
        lectureEvent.StandardDetails();
        Console.WriteLine("");

        Console.WriteLine("Full Details:");
        lectureEvent.FullDetails();
        Console.WriteLine("");

        Console.WriteLine("Short Description:");
        lectureEvent.ShortDescription();
        Console.WriteLine("");

        Address addressObject2 = new Address("194 W 400 N", "American Fork", "UT", "USA");
        string receptionAddress = addressObject.AddressString();
        Reception receptionEvent = new Reception("Grammys", "The 2023 Grammy event", "February 12th", "6.00pm", receptionAddress, "Grammy@gmail.com");

        Console.WriteLine("Standard Details:");
        receptionEvent.StandardDetails();
        Console.WriteLine("");

        Console.WriteLine("Full Details:");
        receptionEvent.FullDetails();
        Console.WriteLine("");

        Console.WriteLine("Short Description:");
        receptionEvent.ShortDescription();
        Console.WriteLine("");

        Address addressObject3 = new Address("4813 Ocean Ave", "Los Angelas", "CA", "USA");
        string outdoorAddress = addressObject.AddressString();
        Outdoor OutdoorEvent = new Outdoor("Battle at the Berrics 13", "Battle at the Berrics 13: Pros vs Joes", "June 7th", "8.00pm", outdoorAddress, "Sunny and 70 degrees");

        Console.WriteLine("Standard Details:");
        OutdoorEvent.StandardDetails();
        Console.WriteLine("");

        Console.WriteLine("Full Details:");
        OutdoorEvent.FullDetails();
        Console.WriteLine("");

        Console.WriteLine("Short Description:");
        OutdoorEvent.ShortDescription();
        Console.WriteLine("");






    }
}