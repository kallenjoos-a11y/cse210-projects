class Eternal : Goal
{
    public Eternal(string goalName, int points, string description) : base(goalName, points, description)
    {}
    public override int RecordEvent()
    {
        return _points;
    }

    public override string ToString()
    {
        return $"[{CheckStatus()}] {_goalName} ({_description})";
    }

    public override string ToCSV()
    {
        return $"Eternal,{_goalName},{_description},{_points}";
    }
}