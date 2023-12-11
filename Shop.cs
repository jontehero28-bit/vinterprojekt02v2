public class Shop
{
    Item item = new();
    
    public List<Item> items = new() { };
    List<string> Names = new() {"Hidden Blade", "Guts Sword", "Blades of Chaos", "Behelit", "Buster Sword", "Master Sword", "An'ferthe"}; //7 items
    
    public void ListItemsInShop() //skriva ut texten (jag ville använda en foreach loop) och alla items
    {
        Console.WriteLine("Här är grejerna du kan köpa!\n");
        foreach (Item i in items)
        {
            Console.WriteLine(i.Name);

        }
        
    }
    public Shop() {
        for (int i = 0; i < 7; i++)
        {
            Item item = new();
            item.Name = Names[i];
            items.Add(item);
        }
    }

}

