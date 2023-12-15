//Shop, inventory, items

Shop shop = new();
Inventory inventory = new();
int i;

bool GameOn = true;

while (true)//main loop
{
    while (GameOn == true) //bara så att den körs om hela tiden
    {

        Console.WriteLine("Välkommen till min lilla fina svärd shop!\n");
        shop.ListItemsInShop();
        inventory.InventoryItems();
        Console.WriteLine($"Du har {inventory.inventorySpace} plats kvar");
        
        i = svar1();

        inventory.items.Push(shop.items[i]);
        shop.items.RemoveAt(i);
        inventory.InventoryItems();
        
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
