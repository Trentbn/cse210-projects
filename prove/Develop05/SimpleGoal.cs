public class SimpleGoal : Goal
{
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{GetComplete()}";
    }

    public override SimpleGoal LoadGoal(string goalDetails)
    {
        
        string[] goalInfo = goalDetails.Split(",");
        
        SimpleGoal newGoal = new SimpleGoal();
        newGoal.SetName(goalInfo[0]);
        newGoal.SetDescription(goalInfo[1]);
        newGoal.SetPoints(int.Parse(goalInfo[2]));
        newGoal.SetComplete(bool.Parse(goalInfo[3]));

        return newGoal;
        
    }

    public override int RecordGoal()
    {
        return base.RecordGoal();
        SetComplete(true);
    }
}