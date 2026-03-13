class Checklist : Goal
{
    private int _targetCount;
    private int _currCount;
    private int _bonusPoints;

    public Checklist(string goalName, int points, string description, int targetCount, int bonusPoints) : base(goalName, points, description)
    {
        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
    }

    public Checklist(string goalName, int points, string description, int targetCount, int currCount, int bonusPoints) : base(goalName, points, description)
    {
        _targetCount = targetCount;
        _currCount = currCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        
        if (_isComplete) return 0;
        _currCount++;

        int earned = _points;
        if (_currCount >= _targetCount)
        {
            _isComplete = true;
            earned += _bonusPoints; 
        }
        return earned;
    }

    public override string ToString()
    {
        return $"[{CheckStatus()}] {_goalName} ({_description}) - Currently completed: {_currCount}/{_targetCount}";
    }

    public override string ToCSV()
    {
        return $"Checklist,{_goalName},{_description},{_points},{_targetCount},{_currCount},{_bonusPoints}";
    }
}