using System.Net.ServerSentEvents;
using System.Runtime.InteropServices;

public class Warrior : Character
{
    private List<Item> _inventory; 
    //a method may have to be written to add items here from game

    public Warrior(string name) : base(name, 100, 11, 8)
    {
        _inventory = new List<Item>();
    }

    public Warrior() : base("Calvin", 100, 11, 8)
    {
        //random weapon chosen at the beginning??
        _inventory = new List<Item>();
    }


    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public void Rest()
    {
        
    }

    public void UseItem()
    {
        
    }
}