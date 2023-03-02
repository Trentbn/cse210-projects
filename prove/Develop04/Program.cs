using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        do
        {
            // MENU // 
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            choice = int.Parse(Console.ReadLine());

            // BREATHING ACTIVITY //
            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breath = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                breath.DisplayStartMessage();
                
                breath.PauseSpinner(5);
                breath.RunActivity();
                Console.Clear();

                breath.DisplayEndMessage();
                breath.PauseSpinner(5);
            }

            // REFLECTION ACTIVITY //
            if (choice == 2)
            {
                Console.Clear();
                ReflectionActivity reflection = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
                reflection.DisplayStartMessage();

                reflection.PauseSpinner(5);
                reflection.RunActivity();
                Console.Clear();

                reflection.DisplayEndMessage();
                reflection.PauseSpinner(5);
            }

            // LISTING ACTIVITY //
            if (choice == 3)
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30);

                listing.DisplayStartMessage();

                listing.PauseSpinner(5);
                listing.RunActivity();
                listing.PauseSpinner(5);
                Console.Clear();

                listing.DisplayEndMessage();
            }
            
        } while (choice != 4);

    }
}