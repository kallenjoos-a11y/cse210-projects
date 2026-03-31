public abstract class Item
{
    private string _name;

    public Item(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract void Use(Warrior warrior);
}