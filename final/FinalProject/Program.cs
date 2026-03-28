using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dragon Warrior Game!!");
        Console.WriteLine("Press enter when you want to start the game: ");
        Console.ReadLine();

        StartStory();
    }

    public static void StartStory()
    {
        Warrior w;
        Console.Write("Would you like to name the warrior or go with the default name? (d=Default, u=Unique)");
        if(Console.ReadLine().ToLower() == "d")
        {
            w = new Warrior();
        } else
        {
            Console.Write("What would you like to name the warrior? ");
            w = new Warrior(Console.ReadLine());
        }

        Console.WriteLine($"{w.GetName()} the brave,");
        Thread.Sleep(1000);

        Console.WriteLine("you have been called by the King himself."); 
        Thread.Sleep(1000);

        Console.Write("You must cross the dangerous paths of Morcalti ");
        Thread.Sleep(1000);

        Console.WriteLine("and save the young princess Buttercup who has been taken by the great dragon king Jercatti and his minions.");
        Thread.Sleep(1500);
        
        Console.WriteLine("Will you accept this daring quest? (Y/N)");
        Thread.Sleep(500);

        Console.Write("> ");
        if(Console.ReadLine().ToLower() == "y")
        {
            Game game = new Game(w);
            game.GenerateEnemy();
            Console.WriteLine("Congratulations! Your quest will begin immediately. Be wise, I wish you luck, and remember, don't run too fast, but the King's daughter's life is at risk, so don't waste any time or it may be too late... ");
            while(w.CheckAlive() && game.CheckTurns()){
                game.DoTurn();
            }
        }
        else
        {
            return;
        }
    }
}