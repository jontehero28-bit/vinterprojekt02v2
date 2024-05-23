public class Inventory //behöver lista för att skriva ut vilka föremål jag har
{
    public Stack<ShopItem> items = new(); //samam lista fast här
    public int inventorySpace = 4;
    public void InventoryItems()
    {
        Console.WriteLine("Du har dessa föremål:\n");
        foreach (ShopItem i in items)
        {
            if (i is Swordspeed)
            {
                Console.Write(((Swordspeed)i).Speed);
            }
            if (i is Weapon)
            {
                Console.Write(((Weapon)i).Length);
            }
            Console.WriteLine(i.Name);
        }
    }
}