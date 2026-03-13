class Simple : Goal
{
    public Simple(string goalName, int points, string description) : base(goalName, points, description)
    {}

    public Simple(string goalName, int points, string description, bool isComplete) : base(goalName, points, description, isComplete)
    {}
    public override int RecordEvent()
    {
        if(_isComplete) return 0;

        _isComplete = true;
        return _points;
    }

        public override string ToString()
    {
        return $"[{CheckStatus()}] {_goalName} ({_description})";
    }

    public override string ToCSV()
    {
        return $"Simple,{_goalName},{_description},{_points},{_isComplete}";
    }
}