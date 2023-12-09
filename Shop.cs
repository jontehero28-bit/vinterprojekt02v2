public class Shop
{
    Item item = new();
    
    public List<Item> items = new() { };

    public void ListItemsInShop() //skriva ut alla items
    {
        Console.WriteLine("Här är grejerna du kan köpa!");
        foreach (Item i in items)
        {
            Console.WriteLine(i.Name);
        }
    }

    public Shop()
    {
        List<string> Names = new() {"Yxa", "Guts Svärd", "Katana", "Behelit", "Battleaxe", "Ishidoros dagger", "Serpicos sword"};
        for (int i = 0; i < 5; i++)
        {
            
        }

    }
}

