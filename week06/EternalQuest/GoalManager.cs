using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _score += _goals[index].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
}
