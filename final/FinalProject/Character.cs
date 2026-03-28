public abstract class Character
{
    private string _name;
    private int _stamina;
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

    public abstract void Attack();

    public virtual bool CheckAlive()
    {
        // if (isAlive)
        // {
            
        // }
        return true;
    }

    public string GetName()
    {
        return _name;
    }
}