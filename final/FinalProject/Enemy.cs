public class Enemy : Character
{
    public Enemy(string name, int stamina, int maxHit, int minHit) : base(name, stamina, maxHit, minHit)
    {}
    public override void Attack()
    {
        throw new NotImplementedException();
    }
}