//Shop, inventory, items
//name space

Shop shop = new();
Inventory inventory = new();
 

bool GameOn = true;

while (true)//
{
    while (GameOn == true) //bara så att den körs om hela tiden
    {
        Console.WriteLine("Välkommen till min lilla fina shop!");
        Console.WriteLine("");
        shop.ListItemsInShop();
        inventory.InventoryItems();
        Console.WriteLine($"Du har {inventory.inventorySpace} plats kvar");



        Console.ReadLine();
    }

}

Console.ReadLine();