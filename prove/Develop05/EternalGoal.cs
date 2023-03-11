public class EternalGoal : Goal
{
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }

    public override EternalGoal LoadGoal(string details)
    {
        string[] goalInfo = details.Split(",");
        
        EternalGoal newGoal = new EternalGoal();
        newGoal.SetName(goalInfo[0]);
        newGoal.SetDescription(goalInfo[1]);
        newGoal.SetPoints(int.Parse(goalInfo[2]));

        return newGoal; 
    }

    public override int RecordGoal()
    {
        int points = GetPoints();
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        
        return points;
    }
}