using System;
public class PromptGenerator
    {
   public List<string> _prompts = new List<string>() {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "What was I most grateful today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "If today was my last day, would I be happy with how I spent my time?",
   };

   public string Display()
   {
    Random rnd = new Random();
    string prompt = _prompts[rnd.Next(0, _prompts.Count)];
    Console.WriteLine(prompt);
    return prompt;
   }
    }
