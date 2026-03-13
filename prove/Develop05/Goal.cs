abstract public class Goal
{
    protected string _goalName;
    protected int _points;
    protected string _description;
    protected bool _isComplete;

    public Goal(string goalName, int points, string description)
    {
        _goalName = goalName;
        _points = points;
        _isComplete = false;
        _description = description;
    }

    public Goal(string goalName, int points, string description, bool isComplete)
    {
        _goalName = goalName;
        _points = points;
        _isComplete = isComplete;
        _description = description;
    }

    public string CheckStatus()
    {
        if (_isComplete)
        {
            return "X";
        } else
        {
            return "";
        }
    }

    public abstract string ToCSV();
    public override abstract string ToString();
    public abstract int RecordEvent();

}