using System.Runtime.CompilerServices;

public class Market
{
    Utility utility = new();
    public List<Item> Items = new() { };   //Lista för items på Market.

    public void ListItemsInMarket(Market market)
    {
        Console.WriteLine("Välkommen till Market");
        Console.WriteLine("Du kan försöka sno dessa föremål");
        

        foreach (Item i in market.Items)
        {
            if (i is FreshItem)
            {
                Console.Write(((FreshItem)i).Vegetable);
            }
            Console.Write(i.Name + "(" + i.RequiredSpace + ")" + ",");
        }
    }

}