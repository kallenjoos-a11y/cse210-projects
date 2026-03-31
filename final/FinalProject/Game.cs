public class Game
{
    private Warrior _warrior;
    private List<Enemy> _enemies;
    private int _turnsDone;
    private bool _victory;
    private bool _itemFound;
    private Random _random;

    public Game(Warrior warrior){
        _warrior = warrior;
        _enemies = new List<Enemy>();
        _turnsDone = 0;
        _victory = false;
        _itemFound = false;
        _random = new Random();
    }

    public bool Victory => _victory;
    public Enemy GenerateEnemy()
{
    int roll = _random.Next(1, 4);

    if (_turnsDone >= 5)
        return new Dragon();

    if (roll == 1)
        return new Goblin();
    else
        return new Skeleton();
}

    public void DoTurn()
    { 
        if(_turnsDone > 15){
            Console.WriteLine("You spend too much time and receive news that the princess died. You lost.");
            return;
        }
        _turnsDone++;


        Enemy enemy = GenerateEnemy();

        if (enemy is Dragon && !_itemFound)
        {
            Console.WriteLine("\nAs you reach the dragon's lair, you discover a hidden item left behind by a fallen traveler!");
            PickItem(false);
        }

        Console.WriteLine($"\nA {enemy.GetName()} appears!");

        while (enemy.CheckAlive() && _warrior.CheckAlive())
        {
            Console.WriteLine($"\nYour stamina: {_warrior.GetStamina()}");
            Console.WriteLine($"{enemy.GetName()} stamina: {enemy.GetStamina()}");

            Console.WriteLine("1. Attack\n2. Rest\n3. Use item");
            Console.Write(" > ");
            string choice = Console.ReadLine();

            Console.Clear();

            if (choice == "1")
            {
                _warrior.Attack(enemy);
            }
            else if (choice == "2")
            {
                _warrior.Rest();
            }
            else if (choice == "3")
            {
                if (!_warrior.UseItem())
                {
                    Console.WriteLine("You have no items to use or you made an invalid choice.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. You hesitate and lose your chance to strike.");
            }

            if (enemy.CheckAlive())
            {
                enemy.Attack(_warrior);
            }
        }

        if (_warrior.CheckAlive())
        {
            if (enemy is Dragon)
            {
                _victory = true;
                Console.WriteLine($"\nYou have defeated the {enemy.GetName()}!");
                Console.WriteLine("The Dragon King collapses, and the princess is finally free!");
                Console.WriteLine($"Your final stamina is {_warrior.GetStamina()}");
            }
            else
            {
                Console.WriteLine($"\n{enemy.GetName()} defeated!");
                DetermineIfItemFound();
            }
        }
        else
        {
            Console.WriteLine($"\nYou were defeated by the {enemy.GetName()}...");
        }
    }

    public bool CheckTurns()
    {
        return !_victory && _turnsDone < 15;
    }

    public void DetermineIfItemFound()
    {
        int roll = _random.Next(1, 101);

        if(roll <= 40)
        {
            PickItem(true);
        } else if(roll <= 55)
        {
            PickItem(false);
        } else
        {
            Console.WriteLine("No item found");
        }
    }

    public void PickItem(bool isNormal)
    {
        Item item;
        int roll = _random.Next(1, 3);

        if(roll == 1)
        {
            item = new Sword((isNormal) ? "rock sword" : "diamond sword", (isNormal) ? 3 : 6);
        } else
        {
            item = new Potion((isNormal) ? "frog eye potion" : "dragon eye potion", (isNormal) ? 35 : 50);
        }

        Console.WriteLine($"You found a {item.GetName()}!");
        _warrior.Add(item);
        _itemFound = true;
    }
}