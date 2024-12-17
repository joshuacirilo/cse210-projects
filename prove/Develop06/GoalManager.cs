using  System;
using System.ComponentModel.Design;
class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal goal = _goals[goalIndex];
        goal.RecordCompleted();
        _totalScore += goal.IsCompleted() ? goal._goalPoints : 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetDetails());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            _totalScore = int.Parse(reader.ReadLine());
            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}