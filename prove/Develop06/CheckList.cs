class CheckList : Goal
{
    private int _targetToComplete;
    private int _targetCompleted;
    private int _bonusPoints;

    public CheckList(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _targetToComplete = target;
        _targetCompleted = 0;
        _bonusPoints = bonus;
    }

    public override void RecordCompleted()
    {
        if (_targetCompleted < _targetToComplete)
        {
            _targetCompleted++;
        }
    }

    public override bool IsCompleted()
    {
        return _targetCompleted >= _targetToComplete;
    }

    public override string GetDetails()
    {
        return $"[ {(IsCompleted() ? "X" : " ")} ] {_goalName} ({_goalDescription}) - {_goalPoints} points per completion. Completed {_targetCompleted}/{_targetToComplete}. Bonus: {_bonusPoints} points on completion.";
    }
}