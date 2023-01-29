using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string userChoice = "";

        Journal journal = new Journal();

        /* Menu */
        do {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        userChoice = Console.ReadLine();



        /* 1. Write */
        if (userChoice == "1")
        {

            Entry entry = new Entry();
            PromptGenerator prompt = new PromptGenerator();


            /* Generates a prompt and stores in Entry */
            entry._prompt = prompt.Display();

            /* Save users entry into a variable. Save that variable to the Entry */
            string userEntry = Console.ReadLine();
            entry._entry = userEntry;

            entry._date = "January 2022";

            /* Adds entry to list in Journal */
            journal._entries.Add(entry);
        }

        /* 2. Display */
        else if (userChoice == "2")
        {
            journal.Display();
        }

        /* 3. Load */
        else if (userChoice == "3")
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            journal.Load(filename);
        }

        /* 4. Save */
        else if (userChoice == "4")
        {
            Console.WriteLine("What is the filename?");
            string filename = Console.ReadLine();
            journal.Save(filename);
        }


        } while (userChoice != "5");

    



    }
}