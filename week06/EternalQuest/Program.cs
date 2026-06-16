using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.AddGoal(new SimpleGoal("Run Marathon", "Complete a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read Scriptures", "Daily scripture study", 100));
        manager.AddGoal(new ChecklistGoal("Temple Visits", "Attend temple 10 times", 50, 10, 500));

        manager.DisplayGoals();
        manager.DisplayScore();

        Console.WriteLine("\nRecording events...");
        manager.RecordGoalEvent(0); // Marathon
        manager.RecordGoalEvent(1); // Scriptures
        manager.RecordGoalEvent(2); // Temple visit

        manager.DisplayGoals();
        manager.DisplayScore();
    }
}
