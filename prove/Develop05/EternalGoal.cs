class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override string Save()
    {
        return $"{_name},{_points},{_isCompleted}";
    }

    public override void Load(string data)
    {
        var parts = data.Split(',');
        _name = parts[0];
        _points = int.Parse(parts[1]);
        _isCompleted = bool.Parse(parts[2]);
    }

    public override void RecordEvent(ref int userScore)
    {
        userScore += _points; // Eternal goals never complete
    }

    public override string ToString()
    {
        return $"{_name} ({_points} points, repeatable)";
    }
}