public class GoalManager
{
    List<Goal> _goals;
    int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0; 
        //make sure that _total points when code comes back in changes
    }

    public void DisplayGoals()
    {
        for(int i = 0; i < _goals.Count(); i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i]}");
            }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        { 
            outputFile.WriteLine($"TOTAL,{_totalPoints}");
            foreach (Goal e in _goals)
            {
                outputFile.WriteLine(e.ToCSV());
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            
            if (line.StartsWith("TOTAL,"))
            {
                _totalPoints = int.Parse(line.Split(',')[1]);
                continue;
            }

            _goals.Add(CreateFromCSV(line));
        }
    }

    public int GetTotal()
    {
        return _totalPoints;
    }

    public override string ToString()
    {
        string output = "";
        foreach (Goal e in _goals)
        {
            output += e.ToString();
            output += "\n-----------------------------------------\n";
        }
        return output;
    }

    public Goal CreateFromCSV(string csv)
    {
        Goal goal;
        string[] parts = csv.Split(",");
        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
    
        if(type == "Simple")
        {
            goal = new Simple(name, points, description, bool.Parse(parts[4]));
        } else if(type == "Eternal")
        {
            goal = new Eternal(name, points, description);
        } else if(type == "Checklist")
        {
            goal = new Checklist(name, points, description, int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
        } else
        {
            return null;
        }
        return goal;
    }

    public void PurchaseFood()
    {
        Console.WriteLine("The available food options are: ");
        Console.WriteLine("1. 12oz can of soda - 20 points");
        Console.WriteLine("2. Can of Pringles - 25 points");
        Console.WriteLine("3. Cheese Burger from Wendy's - 45 points");
        Console.WriteLine("4. Pizza - 65 points");
        Console.WriteLine("5. Steak dinner - 80 points");
        Console.Write("What would you like to buy? ");

        int foodInt = int.Parse(Console.ReadLine());
        string food;
        int cost;
        if(foodInt == 1 && _totalPoints >= 20)
        {
            cost = 20;
            food = "12oz can of soda";
        } else if(foodInt == 2 && _totalPoints >= 25)
        {
            cost = 25;
            food = "Can of Pringles";
        } else if(foodInt == 3 && _totalPoints >= 45)
        {
            cost = 45;
            food = "Cheese Burger from Wendy's";
        } else if(foodInt == 4 && _totalPoints >= 65)
        {
            cost = 65;
            food = "Pizza";
        } else if(foodInt == 5 && _totalPoints >= 80)
        {
            cost = 80;
            food = "Steak Dinner";
        } else
        {
            cost = 0;
            Console.WriteLine("Sorry. There was an error or you may not have enough points. Try again.");
            return;
        }
        
        _totalPoints -= cost;
        Console.WriteLine($"Congratulations!! You bought a {food}. We hope you enjoy the satisfaction of acheiving goals.");
    }
    public static Goal CreateGoal(int goalType, string goalName, int points, string description)
    {
        Goal goal;
        switch (goalType)
        {
            case 1:
                //goal.Display();

                goal = new Simple(goalName, points, description);
                return goal;
            case 2:
                goal = new Eternal(goalName, points, description);
                return goal;
            case 3:
                Console.Write("How many times do you want to repeat the goal? ");
                int repeat = int.Parse(Console.ReadLine());

                Console.Write("How many bonus points should be awarded at the completion? ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new Checklist(goalName, points, description, repeat, bonus);
                return goal;
            default:
                Console.WriteLine("Sorry, that's not a valid choice. Try again.");
                Environment.Exit(0);
                return null;
        }
    }

    public void CallRecorder(int index)
    {
        if(index < 1 || index > _goals.Count)
        {
            Console.WriteLine("Sorry. There's not that amount of goals. Try again.");
            return;
        }
        int earned = _goals[index - 1].RecordEvent();

        _totalPoints += earned;
        Console.WriteLine($"Congratulations!! You have earned {earned} points!!");
    }
}
