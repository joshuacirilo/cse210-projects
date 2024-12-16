using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{

    
    private List<string> _prompts = new List<string>
    {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public override void Run()
    {

        DisplayStartingMessage();

        
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"\n--- Prompt: {randomPrompt} ---");
        int duration = GetDuration();

        Console.WriteLine($"\nYou have {duration} seconds to list as many items as you can. Start now!");

        List<string> userList = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            // Show remaining time every second
            int timeLeft = (int)(endTime - DateTime.Now).TotalSeconds;
            Console.Write($"\rTime remaining: {timeLeft} seconds. Enter an item: "); 

            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && input.ToLower() != "done")
                {
                    userList.Add(input);
                }
            }
            Thread.Sleep(100); 
        }

        Console.WriteLine("\n\nTime's up! Here's what you listed:");

        if (userList.Count > 0)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {userList[i]}");
            }
        }
        else
        {
            Console.WriteLine("You didn't list any items.");
        }

        DisplayEndingMessage();
    }
}


