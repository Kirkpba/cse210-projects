class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

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
}