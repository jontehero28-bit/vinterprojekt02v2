public class Shop
{
    ShopItem item = new();
    
    public List<ShopItem> ShopItems = new() { };
    List<string> ShopNames = new() {"Hidden Blade", "Guts Sword", "Blades of Chaos", "Behelit", "Buster Sword", "Master Sword", "An'ferthe\n"}; //7 items
    
    public void ListItemsInShop() //skriva ut texten (jag ville använda en foreach loop) och alla items
    {
        Console.WriteLine("Här är grejerna du kan köpa!\n");
        foreach (ShopItem i in ShopItems)
        {
            Console.WriteLine(i.Name);

        }
        
    }
    public Shop() {
        for (int i = 0; i < 7; i++)
        {
            ShopItem item = new();
            item.Name = ShopNames[i];
            ShopItems.Add(item);
        }
    }

}

