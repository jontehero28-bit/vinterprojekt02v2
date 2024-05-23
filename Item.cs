public class Item
{
    public string? Name {get; set; } //NOTE GLÖM INTE GÖRA SÅNAAAAAAAA

    int _value = Random.Shared.Next(5, 100); //random value mellan dessa

    public int Value { get { return _value; }set {} }   //funkar det?

    protected int _space = Random.Shared.Next(1, 50); //_space = inventory space det tar i inventory

    public int RequiredSpace
    {
        get {return _space; }

        set
        {
            if (value >= 0 && value <50)    //required value between 0, 50
            {
                _space = value;
            }
        }

    }
}  //--- Class Item

 
public class FreshItem : Item //skapa subclass av superclass Item
{
    public string? Vegetable {get; set; } //kap
    
    string[] _namesVegetableItems = {"Carrot", "Potato", "Cabbage", "Onion", "Tomato", "Broccoli"};

    //kolla om den senaste föremål är fräsch eller möglig
    private static bool _lastIsFresh = false;

    public FreshItem() //construct method för att kolla fräsch eller icke
    {
        int _number = Random.Shared.Next(_namesVegetableItems.Length); //randomize som gjorde förut på deras längd
        
    }

    public virtual string GetNames(int item)
    {
        string i = _namesVegetableItems[item];

        return i;
    }  //får ut namnen för items där.

    public string GetFresh()
    {
        string i;
        if(_lastIsFresh)//om det är fresh returnera den hära texten. 
        {
            i = "Fresh";
        }
        else
        {
            i = "Moldy";
        }
        return i;
    }
    
}

public class Swordspeed : Item
{
    public string Speed;
}

public class Weapon : Swordspeed
{
    public string Length;
}