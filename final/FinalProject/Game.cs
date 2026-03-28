public class Game
{
    private Warrior _warrior;
    private List<Enemy> _enemies;
    private int _turnsDone;
    private Random _random;

    public Game(Warrior warrior){
        _warrior = warrior;
        _enemies = new List<Enemy>();
        _turnsDone = 0;
        _random = new Random();
    }
    public void GenerateEnemy()
    {
        _enemies.Add(new Goblin());
        
    }

    public void DoTurn()
    {
        _turnsDone++;

        Console.WriteLine("");

        FindItem();
    }

    public bool CheckTurns()
    {
        if(_turnsDone >= 15)
        {
            return false;
        } else{
            return true;
        }
    }



    public void FindItem()
    {
        int roll = _random.Next(1, 101);

        if(roll <= 30)
        {
            
        } else if(roll <= 35)
        {
            
        } else
        {
            Console.WriteLine("No item found");
        }
    }

}