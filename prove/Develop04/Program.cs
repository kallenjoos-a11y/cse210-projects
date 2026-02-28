using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int activityChoice = 0;
        Console.WriteLine("Welcome to the program!!");
        while(activityChoice != 4){
            Console.WriteLine("Pick one of the following activities: \n1. Breathe \n2. Reflect \n3. List \n4. Quit ");
            Console.Write("> ");
            string input = Console.ReadLine();

            bool isInt = int.TryParse(input, out activityChoice);

            if (isInt && activityChoice != 4)
            {
                int actDuration = PickActivityLen(activityChoice);
                InitActivity(actDuration, activityChoice);
            } else
            {
                Environment.Exit(0);
                return;
            }
        }
    }

    public static int PickActivityLen(int activityChoice)
    {
        int actDuration = 0;
        
        Console.Write("In seconds, how long would you like to do this activity? ");
        string durationInput = Console.ReadLine();
        bool validDuration = int.TryParse(durationInput, out actDuration);
        if (!validDuration || actDuration <= 0)
        {
            Console.WriteLine("Please enter a valid positive number for duration.");
        }
        return actDuration;
    }

    public static void InitActivity(int actDuration, int activityChoice)
    {
        Activity a1;
        
        if(activityChoice == 1)
        {
            a1 = new Breathe(actDuration);
        }
        else if(activityChoice == 2)
        {
            a1 = new Reflect(actDuration);
        }
        else if(activityChoice == 3)
        {
            a1 = new Lists(actDuration);
        }
        else
        {
            Environment.Exit(0);
            return;
        }
        a1.StartActivity();
        a1.ActivityTimer();
        a1.EndActivity();
    }
}