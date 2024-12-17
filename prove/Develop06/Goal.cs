using System;
public abstract class Goal
{
    protected string _goalName; 
    protected string _goalDescription; 
    public int _goalPoints; 

    public Goal (string name, string description, int point)
    {
        _goalName = name; 
        _goalDescription = description;
        _goalPoints = point; 

    }

    public abstract void RecordCompleted();
    public abstract bool IsCompleted();
    public abstract string GetDetails();

}