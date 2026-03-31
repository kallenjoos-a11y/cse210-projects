public class Enemy : Character
{
    private Random _rand = new Random();
    public Enemy(string name, int stamina, int maxHit, int minHit) : base(name, stamina, maxHit, minHit)
    {}
    public override void Attack(Character target)
    {
        int damage = GetAttackDamage(_rand);
        Console.WriteLine($"{GetName()} attacks for {damage} damage!");
        target.TakeDamage(damage);
    }
}