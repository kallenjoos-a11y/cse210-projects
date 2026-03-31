public class Skeleton : Enemy
{
    public Skeleton() : base("Skeleton", 20, 10, 6)
    {}

    public override void Attack(Character target)
    {
        base.Attack(target);
    }
}