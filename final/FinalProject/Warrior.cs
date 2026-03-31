public class Warrior : Character
{
    private List<Item> _inventory; 
    private int _weaponBonus;
    private string _currentWeapon;

    public Warrior(string name) : base(name, 100, 14, 10)
    {
        _inventory = new List<Item>();
        _weaponBonus = 0;
    }

    public Warrior() : base("Calvin", 100, 11, 8)
    {
        //random weapon chosen at the beginning??
        _inventory = new List<Item>();
        _weaponBonus = 0;
    }

    public override void Attack(Character target)
    {
        int damage = GetAttackDamage(new Random()) + _weaponBonus;

        Console.WriteLine($"You attack for {damage} damage!");
        target.TakeDamage(damage);
    }

    public void Heal(int amount)
    {
        _stamina += amount;
        if (_stamina > 100)
            _stamina = 100;
    }

    public void SetWeapon(string name, int bonus)
    {
        _currentWeapon = name;
        _weaponBonus = bonus;
        Console.WriteLine($"You equipped {_currentWeapon}! Attack bonus is now {_weaponBonus}.");
    }

    public void Rest()
    {
        int healAmount = 15;
        Heal(healAmount);
        Console.WriteLine($"You rest and recover {healAmount} stamina.");
    }

    public bool UseItem()
    {
        if (_inventory.Count == 0)
        {
            return false;
        }

        Console.WriteLine("Inventory:");
        for (int i = 0; i < _inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_inventory[i].GetName()}");
        }

        Console.Write("Choose an item number to use: ");
        if (int.TryParse(Console.ReadLine(), out int choice) &&
            choice >= 1 && choice <= _inventory.Count)
        {
            Item item = _inventory[choice - 1];
            item.Use(this);
            _inventory.RemoveAt(choice - 1);
            return true;
        }

        Console.WriteLine("Invalid item choice.");
        return false;
    }

    public void Add(Item item)
    {
        _inventory.Add(item);
    }
}