using System;
class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    private void DisplayQuestionsWithTimer()
    {
        int remainingTime = _duration;
        int questionIndex = 0;

        while (remainingTime > 0 && questionIndex < _questions.Count)
        {
            Console.Clear();
            Console.WriteLine($"Time remaining: {remainingTime} seconds");
            Console.WriteLine($"> {_questions[questionIndex]}");

            // Wait 5 seconds for each question or until time runs out
            int timeForQuestion = Math.Min(5, remainingTime);
            ShowCountDown(timeForQuestion);

            remainingTime -= timeForQuestion;
            questionIndex++;
        }

        if (remainingTime <= 0)
        {
            Console.WriteLine("\nTime is up! Ending the activity.");
        }
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"\nPrompt: {GetRandomPrompt()}");
        Console.WriteLine("Think deeply about this for a moment...");
        ShowSpinner(5);
        DisplayQuestionsWithTimer();
        DisplayEndingMessage();
    }
}
