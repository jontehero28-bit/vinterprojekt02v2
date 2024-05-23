//Shop, inventory, items

Shop shop = new();
Inventory inventory = new();
Market market = new();
Utility utility = new();    //utility kommer innehålla fuktioner som jag kan inte lägga till någon annanstans.
int i;

bool GameOn = false;

while (true)//main loop
{
    GameOn = utility.StartGame(GameOn);

    while (GameOn == true) //bara så att den körs om hela tiden
    {

        Console.WriteLine("Välkommen till min lilla fina svärd shop!\n");
        shop.ListItemsInShop();
        inventory.InventoryItems();
        Console.WriteLine($"Du har {inventory.inventorySpace} plats kvar");
        
        i = svar1();

        inventory.items.Push(shop.ShopItems[i]);
        shop.ShopItems.RemoveAt(i);
        inventory.InventoryItems();
        if (inventory.inventorySpace == 0) //ifall inventory space = 0 då stängs av spelet.
        {
            Console.WriteLine("Väskan blev för tung och du dog.");
            
            GameOn = false;
        }
        
    }

}

int Tasiffra()//tryparse
{
    string i = "";

    int j;
    while (!int.TryParse(i, out j) == true)
    {
        i = Console.ReadLine();
    }
    return j;
}

int svar1()
{
    Console.WriteLine("");
    Console.WriteLine("Skriv ett nummer mellan 0-6");
    while (true)
    {
        int j = Tasiffra();
        if (j >= 0 && j < 7)
        {
            inventory.inventorySpace--;
            return j;
        }
        else if (inventory.inventorySpace == 0)
        {
            Console.WriteLine("Du har slut på plats i fickorna.");
        }

        else
        {
            Console.WriteLine("Skriv mellan 0-6");
        }
    }
}
