class ExponentialGoal : Goal //By exponential I mean it goes up by three
{
    private int _targetCount;
    private int _currentCount;
    private int _basePoints;

    public ExponentialGoal(string name, int basePoints, int targetCount)
        : base(name, basePoints)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _basePoints = basePoints;
    }

    public override string Save()
    {
        return $"{_name},{_basePoints},{_targetCount},{_currentCount},{_isCompleted}";
    }

    public override void Load(string data)
    {
        var parts = data.Split(',');
        _name = parts[0];
        _basePoints = int.Parse(parts[1]);
        _targetCount = int.Parse(parts[2]);
        _currentCount = int.Parse(parts[3]);
        _isCompleted = bool.Parse(parts[4]);
    }

    public override void RecordEvent(ref int userScore)
    {
        if (!_isCompleted)
    {
        _currentCount++;
        int pointsEarned = _currentCount * 3;
        userScore += pointsEarned;

        if (_currentCount >= _targetCount)
        {
            _isCompleted = true;
        }
    }
    }

    public override string ToString()
    {
        return $"{(_isCompleted ? "[X]" : "[ ]")} {_name} (Base {_basePoints} points, Completed {_currentCount}/{_targetCount}, Exponential growth)";
    }
}
