public abstract class Goal
{
    // ATTRIBUTES //
    private string _name;
    private string _description;
    private int _points;
    private Boolean _complete = false;

    // GETTERS/SETTERS //
    public string GetName(){
        return _name;
    }
    public void SetName(string name){
        _name = name;
    }

    public string GetDescription(){
        return _description;
    }
    public void SetDescription(string description){
        _description = description;
    }

    public int GetPoints(){
        return _points;
    }
    public void SetPoints(int points){
        _points = points;
    }

    public Boolean GetComplete(){
        return _complete;
    }
    public void SetComplete(bool complete){
        _complete = complete;
    }

    // METHODS //
    public virtual void CreateGoal()
    {
        Console.WriteLine("What is the name of this goal? ");
        _name = Console.ReadLine();

        Console.WriteLine("What is a short description of this goal? ");
        _description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());

    }

    public virtual void DisplayGoal()

    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public virtual string GetStringRepresentation()
    {
        return $"Goal:{_name},{_description},{_points}";
    }

    public virtual int RecordGoal()
    {
        int points = _points;

        return points;
    }
    public abstract Goal LoadGoal(string details);
    
}