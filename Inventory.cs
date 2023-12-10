public class Inventory //behöver lista för att skriva ut vilka föremål jag har
{
    public List<Item> items = new(); //samam lista fast här
    public int inventorySpace = 3;
    public void InventoryItems()
    {
        Console.WriteLine("Du har");
        foreach (Item i in items)
        {
            Console.WriteLine(i.Name);
        }
    }
}