public class Dragon : Enemy
{
    public Dragon() : base("Dragon", 60, 20, 15)
    {}

    public override void Attack(Character target)
    {
        base.Attack(target);
    }
}