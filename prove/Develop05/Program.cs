using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static GoalManager manage = new GoalManager();
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal setting game!!");
        Console.WriteLine("Earn points to eat free at your favorite restaurant through acheiving your goals!!\n\n");

        int keepGoing = 0;

        while(keepGoing != 7){
            keepGoing = Menu(manage);
        }
    }
    public static int Menu(GoalManager manage)
    {
        Console.WriteLine($"You have {manage.GetTotal()} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Purchase Food");
        Console.WriteLine("7. Quit");
        Console.Write("Select a choice from the menu: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Goal goal = GetGoalInput();;
                //Console.Write()
                manage.AddGoal(goal);
                break;
            case 2: 
                manage.DisplayGoals();
                break;
            case 3:
                Console.Write("What is the name of the file where you want to store it? ");
                manage.SaveToFile(Console.ReadLine());
                break;
            case 4:
                Console.Write("What is the name of the file where you stored your goals at? ");
                manage.LoadFromFile(Console.ReadLine());
                break;
            case 5:
                manage.DisplayGoals();
                Console.Write("What goal did you accomplish? ");
                manage.CallRecorder(int.Parse(Console.ReadLine()));
                break;
            case 6:
                manage.PurchaseFood();
                break;
            case 7:
                Environment.Exit(0);
                break;

        }
        return choice;
    }

    public static Goal GetGoalInput()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What's your goals name? ");
        string goalName = Console.ReadLine();

        Console.Write("Write a short description of this goal: ");
        string description = Console.ReadLine();

        Console.Write("How many points are related to this goal? ");
        int points = int.Parse(Console.ReadLine());

        
        return GoalManager.CreateGoal(goalType, goalName, points, description);
    }
}