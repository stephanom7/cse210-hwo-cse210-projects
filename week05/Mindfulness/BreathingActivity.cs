using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") {}

    public void Run()
    {
        StartMessage();
        int duration = GetDuration();

        for (int i = 0; i < duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            Console.WriteLine("Breathe out...");
            ShowSpinner(2);
        }

        EndMessage();
    }
}
