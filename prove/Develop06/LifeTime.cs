class LifeTime : Goal
{
    public LifeTime(string name, string description, int points) : base(name, description, points) { }

    public override void RecordCompleted()
    {
        
    }

    public override bool IsCompleted()
    {
        return false; 
    }

    public override string GetDetails()
    {
        return $"[ ∞ ] {_goalName} ({_goalDescription}) - {_goalPoints} points per completion";
    }
}