abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isCompleted = false;
    }

    public abstract string Save(); // Serialize the goal
    public abstract void Load(string data); // Deserialize the goal

    public virtual void RecordEvent(ref int userScore)
    {
        if (!_isCompleted)
        {
            userScore += _points;
            _isCompleted = true;
        }
    }

    public override string ToString()
    {
        return $"{(_isCompleted ? "[X]" : "[ ]")} {_name} ({_points} points)";
    }
}