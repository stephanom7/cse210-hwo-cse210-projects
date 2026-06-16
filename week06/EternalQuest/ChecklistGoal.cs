public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount)
        {
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"[{(_timesCompleted >= _targetCount ? "X" : " ")}] {GetName()} ({GetDescription()}) -- Completed {_timesCompleted}/{_targetCount}";
    }
}
