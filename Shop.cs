public class Shop
{
    Item item = new();
    
    public List<Item> items = new() { };

    
    public void ListItemsInShop() //skriva ut texten (jag ville använda en foreach loop) och alla items
    {
        Console.WriteLine("Här är grejerna du kan köpa!");
        foreach (Item i in items)
        {
            Console.WriteLine(i.Name);

        }
        List<string> Names = new() {"Hidden Blade", "Guts Sword", "Blades of Chaos", "Behelit", "Buster Sword", "Master Sword", "An'ferthe"}; //7 items
        for (int i = 0; i < Names.Count; i++)
        {
            Console.WriteLine(Names[i]);
            
        }
    }

}

