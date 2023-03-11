using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        List<Goal> goals = new List<Goal>();
        string userChoice = "";
        Console.Clear();
        
        do
        {
            Console.WriteLine($"You have {points} points");

            // MENU
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Please select a choice from the menu: ");
            userChoice = Console.ReadLine();

            // CREATE NEW GOAL
            if (userChoice == "1") 
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("     1. Simple Goal ");
                Console.WriteLine("     2. Eteranl Goal ");
                Console.WriteLine("     3. Checklist Goal ");
                Console.Write("What type of goal would you like to create?");

                string goalChoice = Console.ReadLine();

                // SIMPLE GOAL
                if (goalChoice == "1")
                {
                   SimpleGoal simpleGoal = new SimpleGoal();
                   simpleGoal.CreateGoal();
                   goals.Add(simpleGoal);
                }
                
                // ETERNAL GOAL
                if (goalChoice == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    goals.Add(eternalGoal);
                }

                // CHECKLIST GOAL
                if (goalChoice == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal();
                    goals.Add(checklistGoal);
                }




            } 

            // LIST GOALS
            if (userChoice == "2") 
            {
                int i = 1;
                foreach(Goal goal in goals)
                {
                   Console.Write($"{i}. ");
                   goal.DisplayGoal();
                   i++;
                }
            }

            // SAVE GOALS
            if (userChoice == "3") 
            {
                Console.Write("What is the name of the file you would like to save to? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine(points);

                    foreach(Goal goal in goals)
                    {
                        string goalInfo = goal.GetStringRepresentation();
                        outputFile.WriteLine(goalInfo);
                    }
                }
                
            }

            // LOAD GOALS
            if (userChoice == "4") 
            {
                Console.Write("What is the name of the file you would like to load from? ");
                string filename = Console.ReadLine();

                string[] data1 = System.IO.File.ReadAllLines(filename);
                points = int.Parse(data1[0]);
                string[] data = System.IO.File.ReadAllLines(filename).Skip(1).ToArray();
                foreach (string line in data)
                {
                    string[] parts = line.Split(":");
                    string goalType = parts[0];
                    string goalDetails = parts[1];

                    if (goalType == "SimpleGoal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal().LoadGoal(goalDetails);
                        
                        goals.Add(simpleGoal);
                    }

                    if (goalType == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal().LoadGoal(goalDetails);
                        goals.Add(eternalGoal);
                    }

                    if (goalType == "ChecklistGoal")
                    {
                        ChecklistGoal checklistGoal = new ChecklistGoal().LoadGoal(goalDetails);
                        goals.Add(checklistGoal);
                    }
                }
                
            }

            // RECORD EVENT
            if (userChoice == "5") 
            {
                Console.WriteLine("The goals are:");
                int i = 1;

                foreach (Goal goal in goals)
                {
                    Console.Write($"{i}. ");
                    Console.WriteLine(goal.GetName());
                    i++;
                }

                Console.Write("Which goal did you accomplish? ");
                int goalAccomplished = int.Parse(Console.ReadLine());

                Goal goalChoice = goals[goalAccomplished -1];

                points += goalChoice.RecordGoal();

                Console.WriteLine($"Congratulations! You have earned {goalChoice.GetPoints()} points!");
                

            } 

        } while (userChoice != "6");
    }
}