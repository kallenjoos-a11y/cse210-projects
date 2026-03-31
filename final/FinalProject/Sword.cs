public class Sword : Item
{
    private int _hitIncrease;
    public Sword(string name, int hit) : base(name)
    {
        _hitIncrease = hit;
    }
    public override void Use(Warrior warrior)
    {
        warrior.SetWeapon(GetName(), _hitIncrease);
    }
}