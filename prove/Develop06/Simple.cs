using System;
class Simple : Goal
{
    private bool _isCompleted;

    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordCompleted()
    {
        _isCompleted = true;
    }

    public override bool IsCompleted()
    {
        return _isCompleted;
    }

    public override string GetDetails()
    {
        return $"[ {(IsCompleted() ? "X" : " ")} ] {_goalName} ({_goalDescription}) - {_goalPoints} points";
    }

}