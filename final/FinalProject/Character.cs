public abstract class Character
{
    private string _name;
    protected int _stamina;
    private bool _isAlive;
    private int _maxHit;
    private int _minHit;

    public Character(string name, int stamina, int maxHit, int minHit){
        _name = name;
        _stamina = stamina;
        _isAlive = true;
        _maxHit = maxHit;
        _minHit = minHit;
    }

    public abstract void Attack(Character target);

    public string GetName()
    {
        return _name;
    }

    public int GetAttackDamage(Random rand)
    {
        return rand.Next(_minHit, _maxHit + 1);
    }

    public void TakeDamage(int damage)
    {
        _stamina -= damage;
        if (_stamina <= 0)
        {
            _stamina = 0;
            _isAlive = false;
        }
    }

    public int GetStamina()
    {
        return _stamina;
    }

    public bool CheckAlive()
    {
        return _isAlive;
    }
}