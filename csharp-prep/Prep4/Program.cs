using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();



        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;

        do
        {
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        
        int sum = 0;

        foreach (int item in numbers)
        {
            sum += item;
        }

        Console.WriteLine($"The sum is {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int item in numbers)
        {
            if (item > max)
            {
                max = item;
            }
        }

        Console.WriteLine($"The max number is: {max}");
    }
        
}