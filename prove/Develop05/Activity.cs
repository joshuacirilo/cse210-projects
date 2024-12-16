using System;
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }


    //starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nStarting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public int GetDuration()
    {
        return _duration;
    }



    //ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done! You have completed {_name} for {_duration} seconds.\n");
        Thread.Sleep(2000);
    }


    //spinner
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }


    //countdown 
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


    public virtual void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(_duration);
        DisplayEndingMessage();
    }



}