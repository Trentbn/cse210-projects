using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        
        static void DisplayMessage()
        {
            Console.WriteLine("Hello and welcome to my program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, your number squared is {number}");
        }

        DisplayMessage();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(username, numberSquared);
    }
}