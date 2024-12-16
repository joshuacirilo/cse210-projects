using System;

class BreathingActivity : Activity
{

    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i += 6) 
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }


}