//Shop, inventory, items

Shop shop = new();
Inventory inventory = new();
int i;

bool GameOn = true;

while (true)//
{
    while (GameOn == true) //bara så att den körs om hela tiden
    {
        Console.WriteLine("Välkommen till min lilla fina svärd shop!");
        Console.WriteLine("");
        shop.ListItemsInShop();
        inventory.InventoryItems();
        Console.WriteLine($"Du har {inventory.inventorySpace} plats kvar");

        i = svar1();
        
        inventory.items.Add(shop.items[i]);
        shop.items.RemoveAt(i);
        inventory.InventoryItems();

    }



}
int svar1()
{
    Console.WriteLine("");
    Console.WriteLine("Skriv ett nummer mellan 0-6");
    while (true)
    {
        int j = GetNummber();
        if (j >= 0 && j < 6)
        {

            return j;
        }

        else
        {
            Console.WriteLine("Skriv mellan 0-6");

            
        }
    }
}
//får ett answer och retunerar en int
int GetNummber()
{
    string i = "";

    int j;
    while (!int.TryParse(i, out j) == true)
    {
        i = Console.ReadLine();
    }
    return j;
}
//kollar så att det är ett nummer och inte text