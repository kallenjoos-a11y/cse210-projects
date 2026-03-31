public class Potion : Item
{
    private int _health;
    public Potion(string name, int health) : base(name)
    {
        _health = health;
    }
    public override void Use(Warrior warrior)
    {
        warrior.Heal(_health);
        Console.WriteLine($"You healed {_health} stamina!");
    }
}