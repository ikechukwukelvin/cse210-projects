using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private List<string> _badges;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _badges = new List<string>();
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest program!");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Points: {_score}");
        Console.WriteLine($"Level: {_level}");
        Console.WriteLine($"Badges: {string.Join(", ", _badges)}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();
        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter Goal Name to Record Event: ");
        string goalName = Console.ReadLine();
        var goal = _goals.Find(g => g.GetDetailsString().Contains(goalName));
        if (goal != null)
        {
            goal.RecordEvent();
            if (goal is EternalGoal)
            {
                _score += goal.GetPoints();
            }
            else if (!goal.IsComplete())
            {
                _score += goal.GetPoints();
            }
            CheckLevelUp();
        }
    }

    public void SaveGoals()
    {
        string filePath = "goals.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        string filePath = "goals.txt";
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        var goal = new SimpleGoal(name, description, points);
                        if (isComplete) goal.RecordEvent();
                        _goals.Add(goal);
                    }
                    else if (type == "EternalGoal")
                    {
                        var goal = new EternalGoal(name, description, points);
                        _goals.Add(goal);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        int amountComplete = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        bool isComplete = bool.Parse(parts[7]);
                        var goal = new ChecklistGoal(name, description, points, target, bonus);
                        for (int i = 0; i < amountComplete; i++)
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                }
            }
        }
    }

    private void CheckLevelUp()
    {
        if (_score >= _level * 1000)
        {
            _level++;
            _badges.Add($"Level {_level} Achieved!");
        }
    }
}
