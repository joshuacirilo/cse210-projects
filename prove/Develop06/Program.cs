using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;


        Console.WriteLine("Hello Develop06 World!");
        GoalManager manager = new GoalManager();

        do
        {
            manager.DisplayScore();

            Console.WriteLine("Menu Options :");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.Write("Enter goal type (simple/Eternal goal/checklist): ");
                    string type = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();

                    Console.Write("Enter goal points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "simple")
                    {
                        manager.CreateGoal(new Simple(name, description, points));
                    }
                    else if (type == "Eternal goal")
                    {
                        manager.CreateGoal(new LifeTime(name, description, points));
                    }
                    else if (type == "checklist")
                    {
                        Console.Write("Enter target completions: ");
                        int target = int.Parse(Console.ReadLine());

                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());

                        manager.CreateGoal(new CheckList(name, description, points, target, bonus));
                    }
                    break;
                case 2:
                    manager.DisplayGoals();
                    Console.Write("Enter goal number to record event: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(goalIndex);
                    break;
                case 3:
                    manager.DisplayGoals();
                    break;
                case 4:
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case 5:
                    Console.Write("Enter filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }


        } while (choice != 6);




    }
}