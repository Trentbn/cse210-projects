public class ChecklistGoal : Goal
{
    
    int _timesToComplete;
    int _completed = 0;
    int _bonusPoints;

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _timesToComplete = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }


    public override void DisplayGoal()
    {
        if (GetComplete() == false)
        {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_completed}/{_timesToComplete})");
        }
        else
        {
            Console.WriteLine($"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_completed}/{_timesToComplete})");
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonusPoints},{_timesToComplete},{_completed}";
    }

    public override ChecklistGoal LoadGoal(string details)
    {
        string[] goalInfo = details.Split(",");

        ChecklistGoal newGoal = new ChecklistGoal();
        newGoal.SetName(goalInfo[0]);
        newGoal.SetDescription(goalInfo[1]);
        newGoal.SetPoints(int.Parse(goalInfo[2]));
        newGoal._bonusPoints = int.Parse(goalInfo[3]);
        newGoal._timesToComplete = int.Parse(goalInfo[4]);
        newGoal._completed = int.Parse(goalInfo[5]);

        return newGoal;
    }

    public override int RecordGoal()
    {
        _completed += 1;
        int points = GetPoints();

        if (_completed == _timesToComplete)
        {
            SetComplete(true);
            points += _bonusPoints;
        }
        
        Console.WriteLine($"Congratulations! You have earned {points} points!");
         
        return points;
    }
}