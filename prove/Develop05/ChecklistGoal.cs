class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override string Save()
    {
        return $"{_name},{_points},{_targetCount},{_currentCount},{_bonusPoints},{_isCompleted}";
    }

    public override void Load(string data)
    {
        var parts = data.Split(',');
        _name = parts[0];
        _points = int.Parse(parts[1]);
        _targetCount = int.Parse(parts[2]);
        _currentCount = int.Parse(parts[3]);
        _bonusPoints = int.Parse(parts[4]);
        _isCompleted = bool.Parse(parts[5]);
    }

    public override void RecordEvent(ref int userScore)
    {
        if (!_isCompleted)
        {
            _currentCount++;
            userScore += _points;

            if (_currentCount >= _targetCount)
            {
                userScore += _bonusPoints;
                _isCompleted = true;
            }
        }
    }

    public override string ToString()
    {
        return $"{(_isCompleted ? "[X]" : "[ ]")} {_name} ({_points} points, Completed {_currentCount}/{_targetCount}, Bonus {_bonusPoints} points)";
    }
}