using System;
using System.Threading;

public abstract class Activity
{
    protected string _description;
    private string _actName;
    protected int _actDuration;

    public Activity(string description, int actDuration, string name)
    {
        _description = description;
        _actDuration = actDuration;
        _actName = name;
    }
    public virtual void StartActivity()
    {
        Console.WriteLine(_description);
        Animate();
        Countdown();
        Console.Clear();
    }

    public void Animate()
    {
        for(int i = 0; i < 2; i++)
        {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b"); 

            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }

    public void ActivityTimer()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_actDuration);
        DateTime currentTime = DateTime.Now;
        
        while(currentTime < futureTime)
        {
            currentTime = Run();
        }
    }
    public abstract DateTime Run();
    
    public void Countdown()
    {
        Console.Write("The activity will start in ");
        for(int i = 3; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
    public virtual void EndActivity()
    {
        MakeInspMess();
        Console.WriteLine("Get ready... ");
        Animate();
        Console.WriteLine($"You participated in the {_actName} activity for {_actDuration} seconds!!!");
        Animate();
    }

    public void MakeInspMess()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        List<string> inspMess = new List<string>{"You can do this!!", "Lock in!", "Peace is the way.", "The way to conquer the world is to conquer your soul"}; 

        Random random = new Random();
        int randInt = random.Next(inspMess.Count);
        Console.WriteLine(inspMess[randInt]);
        Console.ResetColor();
    }
}